using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Auto_Service
{
    public static class Database
    {
        private static readonly string connectionString = "server=localhost;user=root;password=villarroya;database=autoservicedb;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

