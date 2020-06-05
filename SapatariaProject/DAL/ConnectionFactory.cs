using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SapatariaProject.DAL
{
    class ConnectionFactory
    {
        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlDataReader dr;
        private MySqlCommandBuilder cb;

        private String server;
        private String user;
        private String password;
        private String database = "Sapataria";

        public void CreateConnection()
        {
            if (conn != null) conn.Close();

            String connStr = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, user, password, database);
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void SqlCommand(String sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable RetDataTable(String sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }

        public MySqlDataReader RetDataReader(String sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            dr.Read();
            return dr;
        }
    }
}
