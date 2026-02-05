using CareerOpportunity.Models;
using Npgsql;
using System;
using System.Data;
using System.Security.Cryptography;

namespace CareerOpportunity.DAL
{
    public class RecuiterRepository
    {
        public RecuiterRepository()
        {
        }

        // Logic 1: Publish a Job
        public int PublishJob(Job job)
        {
            // Removed 'dbo.', kept logic exactly the same
            string query = @"
                INSERT INTO jobs
                (recruiterid, title, description, requiredskill, experience, jobtype, salaryorbudget, deadline, status)
                VALUES
                (@RecruiterID, @Title, @Description, @RequiredSkill, @Experience, @JobType, @SalaryOrBudget, @Deadline, @Status)";

            using (var con = PgDbConnection.GetConnection())
            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("RecruiterID", job.RecruiterID);
                cmd.Parameters.AddWithValue("Title", job.Title);
                cmd.Parameters.AddWithValue("Description", job.Description);
                cmd.Parameters.AddWithValue("RequiredSkill", job.RequiredSkill);
                cmd.Parameters.AddWithValue("Experience", job.Experience);
                cmd.Parameters.AddWithValue("JobType", job.JobType);
                cmd.Parameters.AddWithValue("SalaryOrBudget", job.SalaryOrBudget);
                cmd.Parameters.AddWithValue("Deadline", job.Deadline);
                cmd.Parameters.AddWithValue("Status", "Pending"); // Hardcoded as per your original logic

                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Logic 2: Get Jobs by Recruiter ID
        public DataTable GetJobsByRecruiter(int recruiterId)
        {
            string query = @"
                            SELECT 
                                jobid, title, description, requiredskill, jobtype, salaryorbudget, deadline, experience, posteddate, status
                            FROM jobs
                            WHERE recruiterid = @RecruiterID
                            ORDER BY jobid DESC;";

            using (var con = PgDbConnection.GetConnection())
            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("RecruiterID", recruiterId);

                using (var a = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    return dt;
                }
            }
        }

        // Logic 3: Delete a Job
        public bool DeleteJob(int jobId)
        {
            string query = "DELETE FROM jobs WHERE jobid = @JobID";

            using (var con = PgDbConnection.GetConnection())
            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("JobID", jobId);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        // Logic 4: Update a Job
        public int Update(Job job)
        {
            string query = @"
                UPDATE jobs
                SET title = @Title,
                    description = @Description,
                    requiredskill = @RequiredSkill,
                    experience = @Experience,
                    jobtype = @JobType,
                    salaryorbudget = @SalaryOrBudget,
                    deadline = @Deadline
                WHERE jobid = @JobID";

            using (var con = PgDbConnection.GetConnection())
            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("JobID", job.JobID);
                cmd.Parameters.AddWithValue("Title", job.Title);
                cmd.Parameters.AddWithValue("Description", job.Description);
                cmd.Parameters.AddWithValue("RequiredSkill", job.RequiredSkill);
                cmd.Parameters.AddWithValue("Experience", job.Experience);
                cmd.Parameters.AddWithValue("JobType", job.JobType);
                cmd.Parameters.AddWithValue("SalaryOrBudget", job.SalaryOrBudget);
                cmd.Parameters.AddWithValue("Deadline", job.Deadline);

                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }



        // Inside CareerOpportunity.DAL.RecuiterRepository

        public DataTable GetApprovedJobs()
        {
            string query = @"
                 SELECT
                    jobid          AS ""JobID"",
                    recruiterid    AS ""RecruiterID"",
                    title          AS ""Title"",
                    description    AS ""Description"",
                    requiredskill  AS ""RequiredSkill"",
                    experience     AS ""Experience"",
                    jobtype        AS ""JobType"",
                    salaryorbudget AS ""SalaryOrBudget"",
                    deadline       AS ""Deadline"",
                    posteddate     AS ""PostedDate"",
                    status         AS ""Status""
                FROM jobs
                WHERE LOWER(TRIM(status)) IN ('approve', 'approved')
                ORDER BY posteddate DESC;";

            using (var con = PgDbConnection.GetConnection())
            using (var cmd = new NpgsqlCommand(query, con))
            using (var da = new NpgsqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }





        public int ApplyForJob(int jobId, int userId)
        {
            using (var conn = PgDbConnection.GetConnection())
            {
                conn.Open();

                // duplicate check
                string check = "SELECT COUNT(*) FROM applications WHERE jobid=@jobid AND userid=@userid;";
                using (var checkCmd = new NpgsqlCommand(check, conn))
                {
                    checkCmd.Parameters.AddWithValue("jobid", jobId);
                    checkCmd.Parameters.AddWithValue("userid", userId);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (exists > 0) return 0; // already applied
                }

                string insert = @"INSERT INTO applications(userid, jobid, applydate, status)
                          VALUES(@userid, @jobid, CURRENT_DATE, 'Applied');";

                using (var cmd = new NpgsqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("userid", userId);
                    cmd.Parameters.AddWithValue("jobid", jobId);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

    }
}


