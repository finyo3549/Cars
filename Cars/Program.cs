using System.Net.NetworkInformation;

namespace Cars
{
    internal static class Program
    {
       public static List<Car> cars = new List<Car>();
        public static DB database = null;
        public static Form_open form_Open = null;
        static void Main()
        {
            database = new DB();
            cars = database.getAllCars();
            form_Open = new Form_open();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_open());
        }
    }
}