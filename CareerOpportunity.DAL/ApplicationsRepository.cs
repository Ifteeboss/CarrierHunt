using System.Data;
using Npgsql;
using System;

namespace CareerOpportunity.DAL
{
    public class ApplicationsRepository
    {
        public DataTable GetApplicantsByJobId(int jobId)
        {
            string query = @"
                               SELECT
                    a.applicationid AS ""ApplicationID"",
                    a.jobid        AS ""JobID"",
                    a.userid       AS ""ApplicantID"",
                    u.username     AS ""UserName"",
                    u.email        AS ""Email"",
                    u.companyname  AS ""CompanyName"",
                    a.applydate    AS ""ApplyDate"",
                    a.status       AS ""Status""
                FROM applications a
                INNER JOIN users u ON u.id = a.userid
                WHERE a.jobid = @JobID
                ORDER BY a.applydate DESC;

            ";

            using (var con = PgDbConnection.GetConnection())
            {
                con.Open();
                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("JobID", jobId);

                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public int GetAppliedJobCount(int userId)
        {
            string query = "SELECT COUNT(*) FROM applications WHERE userid = @UserID";

            using (var con = PgDbConnection.GetConnection())
            {
                con.Open();
                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
  }

