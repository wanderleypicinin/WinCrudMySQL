using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinCrudMySQL.Data
{
    public class Database
    {
        private static string connectionString = "Server=localhost;Port=3306;Database=CrudDEMO;Uid=root;Pwd=Info@2025;";
        public static MySqlConnection GetConnection()

        {
            return new MySqlConnection(connectionString);
        }
    }
}
