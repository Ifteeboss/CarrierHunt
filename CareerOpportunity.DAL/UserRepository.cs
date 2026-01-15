using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CareerOpportunity.Models;
using Npgsql;

namespace CareerOpportunity.DAL
{
    public class UserRepository
    {
        public bool IsUserExists(string userName)
        {
            try
            {
                using (var conn = PgDbConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM users WHERE username=@username";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", userName);
                        conn.Open();
                        long count = (long)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("An error occurred while checking if the user exists." + ex.Message,ex);
            }
        }
        public User ValidateUser(string username, string password)
        {
            using (var conn = PgDbConnection.GetConnection())
            {
                string query = "SELECT id, username,password, email, role,isapproved FROM users WHERE username = @username AND password = @password";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            UserName = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            Email = reader["email"].ToString(),
                            Role = reader["role"].ToString(),
                            IsApproved = Convert.ToBoolean(reader["isapproved"])
                        };
                    }
                    return null;
                }
            }
        }

        public void AddUser(User user)
        {
            try
            {
                using (var conn = PgDbConnection.GetConnection())
                {
                    string query = "INSERT INTO users (username, password, email,role,isapproved) VALUES (@username, @password, @email, @role,@isapproved)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", user.UserName);
                        cmd.Parameters.AddWithValue("password", user.Password);
                        cmd.Parameters.AddWithValue("email", user.Email);
                        cmd.Parameters.AddWithValue("role", user.Role);
                        cmd.Parameters.AddWithValue("isapproved", user.IsApproved);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("An error occurred while adding a new user." + ex.Message, ex);
            }
        }

        public void ApproveUser(int userId)
        {
            using (var conn = PgDbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE users SET isapproved = TRUE WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RejectUser(int userId)
        {
            using(var conn= PgDbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM users WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetPendingUsers()
        {
            using(var conn = PgDbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT id AS id, username, email, role, isapproved FROM users WHERE isapproved = FALSE";
                using(var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    return table;
                }
            }
        }
    }
}
