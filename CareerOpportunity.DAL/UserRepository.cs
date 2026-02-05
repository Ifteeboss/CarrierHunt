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
                string query = "SELECT id, username,password, email, role,companyname,isapproved FROM users WHERE username = @username AND password = @password";
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
                            IsApproved = Convert.ToBoolean(reader["isapproved"]),
                            CompanyName = reader["companyname"].ToString()
                        };
                    }
                    return null;
                }
            }
        }

        public void AddApplicant(User user)
        {
            try
            {
                using (var conn = PgDbConnection.GetConnection())
                {
                    string query = "INSERT INTO users (username, password, email,role,isapproved) VALUES (@username, @password, @email, 'Applicant',@isapproved)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", user.UserName);
                        cmd.Parameters.AddWithValue("password", user.Password);
                        cmd.Parameters.AddWithValue("email", user.Email);
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

        public void AddRecruiter(User user)
        {
            try
            {
                using (var conn = PgDbConnection.GetConnection())
                {
                    string query = "INSERT INTO users (username, password, email,companyname,role,isapproved) VALUES (@username, @password, @email,@companyname, 'Recruiter',@isapproved)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", user.UserName);
                        cmd.Parameters.AddWithValue("password", user.Password);
                        cmd.Parameters.AddWithValue("email", user.Email);
                        cmd.Parameters.AddWithValue("companyname", user.CompanyName);
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

        public string ApproveUser(int userId)
        {
            using (var conn = PgDbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE users SET isapproved = TRUE WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    int rows=cmd.ExecuteNonQuery();
                    return rows > 0 ? "User approved successfully." : "Approval failed.";
                }
            }
        }

        public string RejectUser(int userId)
        {
            using(var conn= PgDbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM users WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    int rows=cmd.ExecuteNonQuery();
                    return rows > 0 ? "User rejected successfully." : "Rejection failed.";
                }
            }
        }

        public DataTable GetPendingUsers(string role)
        {
            using(var conn = PgDbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT id AS id, username, email, role,companyname, isapproved FROM users WHERE isapproved = FALSE AND role =@role";
                using(var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("role", role);
                    var reader = cmd.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    return table;
                }
            }
        }

        public int GetPendingCount(string role)
        {
            int count = 0;
            string query = "SELECT COUNT(*) FROM users WHERE role = @role AND isapproved='false'";
            using (var conn = PgDbConnection.GetConnection())
            {
                conn.Open();
                using(var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@role", role);
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count;
           
        }

        public User GetUserById(int userId)
        {
            using (var conn = PgDbConnection.GetConnection())
            {
                string query = "SELECT id, username, password, email, role, companyname, isapproved FROM users WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", userId);
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
                            IsApproved = Convert.ToBoolean(reader["isapproved"]),
                            CompanyName = reader["companyname"].ToString()
                        };
                    }
                    return null;
                }
            }
        }

        public string UpdateUser(User user)
        {
            using (var conn = PgDbConnection.GetConnection())
            {
                string query = "UPDATE users SET username=@username, password=@password, email=@email, role=@role, companyname=@companyname WHERE id=@id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", user.UserName);
                    cmd.Parameters.AddWithValue("password", user.Password);
                    cmd.Parameters.AddWithValue("email", user.Email);
                    cmd.Parameters.AddWithValue("role", user.Role);
                    cmd.Parameters.AddWithValue("companyname", user.CompanyName);
                    cmd.Parameters.AddWithValue("id", user.Id);
                    conn.Open();
                    int rows=cmd.ExecuteNonQuery();
                    return rows > 0 ? "User updated successfully." : "Update failed.";
                }
            }
        }

        public string DeleteUser(int userId)
        {
            using (var conn = PgDbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM users WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? "User Deleted successfully." : "Deleted failed.";
                }
            }
        }
        public DataTable GetAllUsersByRole(string role) {             using (var conn = PgDbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT id AS id, username, email, role,companyname, isapproved FROM users WHERE role =@role";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("role", role);
                    var reader = cmd.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    return table;
                }
            }
        }

    }
}
