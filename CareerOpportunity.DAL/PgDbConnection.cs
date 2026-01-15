using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CareerOpportunity.DAL
{
    public static class PgDbConnection
    {
        private static string connectionString = "Host= localhost;Port=5432;Database=careerhunt;Username=postgres;Password=4343";
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
