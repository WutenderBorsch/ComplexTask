using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Apps1
{ 
    class DB
    {
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=store; User Id=postgres; Password=123");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public NpgsqlConnection getConnection()
        {
            return connection;
        }
    }
}
