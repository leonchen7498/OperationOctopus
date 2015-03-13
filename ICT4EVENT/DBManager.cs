using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ICT4EVENT
{
    class DBManager
    {
        private MySqlConnection dbConnection;

        public DBManager()
        {
            dbConnection = new MySqlConnection();
            dbConnection.ConnectionString = "SERVER=terarion.com;DATABASE=proftaak2;UID=proftaak2;PASSWORD=FCUGBmvCFJfyGNv6;";
            dbConnection.Open();
        }

        private void QueryDB(string query)
        {
            throw new NotImplementedException();
        }
    }
}
