using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Car
    {
        
        string rendszam;
        string marka;
        string model;
        int gyartasiev;
        DateOnly forgalmiErvenyesseg;
        int vetelar;
        int kmallas;
        int hengerurtartalom;
        int tomeg;
        int teljesitmeny;

        public Car(string rendszam, string marka, string model, int gyartasiev, DateOnly forgalmiErvenyesseg, int vetelar, int kmallas, int hengerurtartalom, int tomeg, int teljesitmeny)
        {
            Rendszam = rendszam;
            Marka = marka;
            Model = model;
            Gyartasiev = gyartasiev;
            ForgalmiErvenyesseg = forgalmiErvenyesseg;
            Vetelar = vetelar;
            Kmallas = kmallas;
            Hengerurtartalom = hengerurtartalom;
            Tomeg = tomeg;
            Teljesitmeny = teljesitmeny;
        }

        public override string? ToString()
        {
            return $"{Marka} {Model} ({vetelar})";
        }

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Gyartasiev { get => gyartasiev; set => gyartasiev = value; }
        public DateOnly ForgalmiErvenyesseg { get => forgalmiErvenyesseg; set => forgalmiErvenyesseg = value; }
        public int Vetelar { get => vetelar; set => vetelar = value; }
        public int Kmallas { get => kmallas; set => kmallas = value; }
        public int Hengerurtartalom { get => hengerurtartalom; set => hengerurtartalom = value; }
        public int Tomeg { get => tomeg; set => tomeg = value; }
        public int Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }
    }
}
