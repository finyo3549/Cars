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
            builder.Database = "autok";
            conn = new MySqlConnection(builder.ConnectionString);
            sql = conn.CreateCommand();
            try
            {
                kapcsolatNyit();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(0);
            }
            finally { kapcsolatZar(); }
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

        internal List<Car> getAllCars()
        {
            List<Car> cars = new List<Car>();
            sql.CommandText = "SELECT * from auto";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string rendszam = dr.GetString("rendszam");
                        string marka = dr.GetString("marka");
                        string model = dr.GetString("model");
                        int gyartasiev = dr.GetInt32("gyartasiev");
                        DateTime forgalmiErvenyessegDateTime = dr.GetDateTime("forgalmiervenyesseg");
                        DateOnly forgalmiErvenyesseg = new DateOnly(forgalmiErvenyessegDateTime.Year, forgalmiErvenyessegDateTime.Month, forgalmiErvenyessegDateTime.Day);
                        int vetelar = dr.GetInt32("vetelar");
                        int kmallas = dr.GetInt32("kmallas");
                        int hengerurtartalom = dr.GetInt32("hengerurtartalom");
                        int tomeg = dr.GetInt32("tomeg");
                        int teljesitmeny = dr.GetInt32("teljesitmeny");
                        cars.Add(new Car(rendszam, marka, model, gyartasiev, forgalmiErvenyesseg, vetelar, kmallas, hengerurtartalom, tomeg, teljesitmeny));
                    }
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                kapcsolatZar();
            }
            return cars;
        }
    
