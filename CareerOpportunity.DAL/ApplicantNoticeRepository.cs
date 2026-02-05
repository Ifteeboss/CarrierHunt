using CareerOpportunity.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace CareerOpportunity.DAL
{
    public class ApplicantNoticeRepository
    {
        // GET ALL NOTICES
        public List<Notice> GetAll()
        {
            List<Notice> list = new List<Notice>();

            using (var con = PgDbConnection.GetConnection())
            {
                // Matches 'noticetable' and 'noticeid' from your schema
                string query = @"SELECT * FROM noticetable ORDER BY noticeid ASC";
                using (var cmd = new NpgsqlCommand(query, con))
                {
                    con.Open();
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(MapNotice(r));
                        }
                    }
                }
            }
            return list;
        }

        // FILTER (Active / Expired)
        public List<Notice> Filter(string status)
        {
            List<Notice> list = new List<Notice>();

            using (var con = PgDbConnection.GetConnection())
            {
                string query = @"SELECT * FROM noticetable";

                // Matches 'deadlinedate' from your schema
                if (status == "Active")
                    query += @" WHERE deadlinedate >= CURRENT_DATE";
                else if (status == "Expired")
                    query += @" WHERE deadlinedate < CURRENT_DATE";

                query += @" ORDER BY noticeid DESC";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    con.Open();
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(MapNotice(r));
                        }
                    }
                }
            }
            return list;
        }

        // SEARCHING BY ID
        public List<Notice> SearchById(int id)
        {
            List<Notice> list = new List<Notice>();

            using (var con = PgDbConnection.GetConnection())
            {
                string query = @"SELECT * FROM noticetable WHERE noticeid=@id";
                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(MapNotice(r));
                        }
                    }
                }
            }
            return list;
        }

        // COMMON MAPPER 
        private Notice MapNotice(NpgsqlDataReader r)
        {
            return new Notice
            {
                // Columns are lowercase to match the screenshot provided
                NoticeId = Convert.ToInt32(r["noticeid"]),
                NoticeTitle = r["noticetitle"].ToString(),
                NoticeType = r["noticetype"].ToString(),
                DetailsBox = r["detailsbox"].ToString(),
                PublishDate = Convert.ToDateTime(r["publishdate"]),
                DeadlineDate = Convert.ToDateTime(r["deadlinedate"])
            };
        }
    }
}