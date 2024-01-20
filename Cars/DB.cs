using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cars
{
     
    internal class DB
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;

        public DB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "192.168.41.1";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "cars";
            conn = new MySqlConnection(builder.ConnectionString);
            sql = conn.CreateCommand();
            try
            {
                kapcsolatNyit();
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(0);
            }
            finally { kapcsolatZar() }
        }

        private void kapcsolatZar()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private void kapcsolatNyit()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }
    }
}
