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
            builder.Server = "localhost";
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
                conn.Close();
            }
        }

        private  void kapcsolatNyit()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }
        internal  void deleteCar(Car car)
        {
            sql.CommandText = "DELETE from auto WHERE rendszam = @rendszam";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@rendszam", car.Rendszam);
            try {
                kapcsolatNyit();
                sql.ExecuteNonQuery();

            } catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            } finally { kapcsolatZar(); } 
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
                        string modell = dr.GetString("modell");
                        int gyartasiev = dr.GetInt32("gyartasiev");
                        DateTime forgalmiErvenyessegDateTime = dr.GetDateTime("forgalmiervenyesseg");
                        DateOnly forgalmiErvenyesseg = new DateOnly(forgalmiErvenyessegDateTime.Year, forgalmiErvenyessegDateTime.Month, forgalmiErvenyessegDateTime.Day);
                        int vetelar = dr.GetInt32("vetelar");
                        int kmallas = dr.GetInt32("kmallas");
                        int hengerurtartalom = dr.GetInt32("hengerűrtartalom");
                        int tomeg = dr.GetInt32("tomeg");
                        int teljesitmeny = dr.GetInt32("teljesitmeny");
                        cars.Add(new Car(rendszam, marka, modell, gyartasiev, forgalmiErvenyesseg, vetelar, kmallas, hengerurtartalom, tomeg, teljesitmeny));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                kapcsolatZar();
            }
            return cars;
        }
        internal void addCar(Car car)
        {
            string formattedDate = car.ForgalmiErvenyesseg.ToString("yyyy-MM-dd");
            sql.CommandText = "INSERT INTO `auto`(`rendszam`, `marka`, `modell`, `gyartasiev`, `forgalmiErvenyesseg`, `vetelar`, `kmallas`, `hengerűrtartalom`, `tomeg`, `teljesitmeny`) VALUES (@rendszam,@marka,@modell,@gyartasiev,@forgalmiervenyesseg,@vetelar,@kmallas,@hengerurtartalom,@tomeg,@teljesitmeny)";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@rendszam", car.Rendszam);
            sql.Parameters.AddWithValue("@marka", car.Marka);
            sql.Parameters.AddWithValue("@modell", car.Modell);
            sql.Parameters.AddWithValue("@gyartasiev", car.Gyartasiev);
            sql.Parameters.AddWithValue("@forgalmiervenyesseg", formattedDate);
            sql.Parameters.AddWithValue("@vetelar", car.Vetelar);
            sql.Parameters.AddWithValue("@kmallas", car.Kmallas);
            sql.Parameters.AddWithValue("@hengerurtartalom", car.Hengerurtartalom);
            sql.Parameters.AddWithValue("@tomeg", car.Tomeg);
            sql.Parameters.AddWithValue("@teljesitmeny", car.Teljesitmeny);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                kapcsolatZar();
            }
        }
    
        internal void updateCar(Car car)
        {
            string formattedDate = car.ForgalmiErvenyesseg.ToString("yyyy-MM-dd");
            sql.CommandText = "UPDATE `auto` SET `rendszam`=@rendszam,`marka`=@marka,`modell`=@modell,`forgalmiErvenyesseg`=@forgalmiervenyesseg,`gyartasiev`=@gyartasiev,`vetelar`=@vetelar,`kmallas`=@kmallas,`hengerűrtartalom`=@hengerurtartalom,`tomeg`=@tomeg,`teljesitmeny`=@teljesitmeny WHERE `rendszam` = @rendszam";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@rendszam", car.Rendszam);
            sql.Parameters.AddWithValue("@marka", car.Marka);
            sql.Parameters.AddWithValue("@modell", car.Modell);
            sql.Parameters.AddWithValue("@gyartasiev", car.Gyartasiev);
            sql.Parameters.AddWithValue("@forgalmiervenyesseg", formattedDate);
            sql.Parameters.AddWithValue("@vetelar", car.Vetelar);
            sql.Parameters.AddWithValue("@kmallas", car.Kmallas);
            sql.Parameters.AddWithValue("@hengerurtartalom", car.Hengerurtartalom);
            sql.Parameters.AddWithValue("@tomeg", car.Tomeg);
            sql.Parameters.AddWithValue("@teljesitmeny", car.Teljesitmeny);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();
                return;
                
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                kapcsolatZar();
            }
            
            
        }

    }
}
    
