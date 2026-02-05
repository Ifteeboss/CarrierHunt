using CareerOpportunity.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerOpportunity.DAL
{
    public class RecruiterNoticeRepository
    {
        // insert korchi notice
        public void Insert(Notice notice)
        {
            using (NpgsqlConnection con = PgDbConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO ""NoticeTable""
                    (""NoticeTitle"", ""NoticeType"", ""DetailsBox"", ""PublishDate"", ""DeadlineDate"")
                    VALUES (@title, @type, @details, @publish, @deadline)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@title", notice.NoticeTitle);
                    cmd.Parameters.AddWithValue("@type", notice.NoticeType);
                    cmd.Parameters.AddWithValue("@details", notice.DetailsBox);
                    cmd.Parameters.AddWithValue("@publish", notice.PublishDate);
                    cmd.Parameters.AddWithValue("@deadline", notice.DeadlineDate);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // update korchi notice
        public void Update(Notice notice)
        {
            using (NpgsqlConnection con = PgDbConnection.GetConnection())
            {
                string query = @"
            UPDATE ""NoticeTable""
            SET ""NoticeTitle""=@title,
                ""NoticeType""=@type,
                ""DetailsBox""=@details,
                ""PublishDate""=@publish,
                ""DeadlineDate""=@deadline
            WHERE ""NoticeID""=@id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", notice.NoticeId);
                    cmd.Parameters.AddWithValue("@title", notice.NoticeTitle);
                    cmd.Parameters.AddWithValue("@type", notice.NoticeType);
                    cmd.Parameters.AddWithValue("@details", notice.DetailsBox);
                    cmd.Parameters.AddWithValue("@publish", notice.PublishDate);
                    cmd.Parameters.AddWithValue("@deadline", notice.DeadlineDate);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // search by id korchi notice,chaile eta list na diyeo kra jaito kintu ami list e korlam
        public List<Notice> SearchById(int id)
        {
            List<Notice> list = new List<Notice>();

            using (NpgsqlConnection con = PgDbConnection.GetConnection())
            {
                string query = @"SELECT * FROM ""NoticeTable"" WHERE ""NoticeID""=@id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();

                    using (NpgsqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new Notice
                            {
                                NoticeId = Convert.ToInt32(r["NoticeID"]),
                                NoticeTitle = r["NoticeTitle"].ToString(),
                                NoticeType = r["NoticeType"].ToString(),
                                DetailsBox = r["DetailsBox"].ToString(),
                                PublishDate = Convert.ToDateTime(r["PublishDate"]),
                                DeadlineDate = Convert.ToDateTime(r["DeadlineDate"])
                            });
                        }
                    }
                }
            }

            return list;
        }



        // delete korchi notice
        public void Delete(int id)
        {
            using (NpgsqlConnection con = PgDbConnection.GetConnection())
            {
                string query = @"DELETE FROM ""NoticeTable"" WHERE ""NoticeID""=@id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //query change krlam jno recruit eo status dekhte pari
        public List<Notice> GetAll()
        {
            List<Notice> list = new List<Notice>();

            using (NpgsqlConnection con = PgDbConnection.GetConnection())
            {
                string query = @"SELECT *,
CASE 
    WHEN ""DeadlineDate"" >= CURRENT_DATE THEN 'Active'
    ELSE 'Expired'
END AS ""Status""
FROM ""NoticeTable""
ORDER BY ""NoticeID"" ASC;
";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    con.Open();
                    using (NpgsqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new Notice
                            {
                                NoticeId = Convert.ToInt32(r["NoticeID"]),
                                NoticeTitle = r["NoticeTitle"].ToString(),
                                NoticeType = r["NoticeType"].ToString(),
                                DetailsBox = r["DetailsBox"].ToString(),
                                PublishDate = Convert.ToDateTime(r["PublishDate"]),
                                DeadlineDate = Convert.ToDateTime(r["DeadlineDate"]),
                                Status = r["Status"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

    }
}