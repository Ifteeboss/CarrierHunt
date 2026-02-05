using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CareerOpportunity.DAL
{
    public class JobRepository
    {
        public string ApproveJob(int jobId)
        {
            using (var conn = PgDbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE jobs SET status = 'Approve' WHERE jobid=@jobid";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@jobid", jobId);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        return "Job Approved Successfully";
                    }
                    else
                    {
                        return "Job Approval Failed";
                    }
                }
            }
        }

        public string RejectJob(int jobId)
        {
            using (var conn = PgDbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM jobs WHERE jobid=@jobid";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@jobid", jobId);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        return "Job Rejected Successfully";
                    }
                    else
                    {
                        return "Job Rejection Failed";
                    }
                }
            }
        }

        public DataTable GetPendingJobs()
        {
            using (var conn = PgDbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM jobs WHERE status='Pending'";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    return table;
                }
            }
        }

        public int GetPendingJobCount()
        {
            int count = 0;
            string query = "SELECT COUNT(*) FROM jobs WHERE status = 'Pending'";
            using (var conn = PgDbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count;

        }

    }
}
