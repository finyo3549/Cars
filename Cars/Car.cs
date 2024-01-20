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
        string modell;
        int gyartasiev;
        DateOnly forgalmiErvenyesseg;
        int vetelar;
        int kmallas;
        int hengerurtartalom;
        int tomeg;
        int teljesitmeny;

        public Car(string rendszam, string marka, string modell, int gyartasiev, DateOnly forgalmiErvenyesseg, int vetelar, int kmallas, int hengerurtartalom, int tomeg, int teljesitmeny)
        {
            Rendszam = rendszam;
            Marka = marka;
            Modell = modell;
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
            return $"{Marka} {Modell} ({Gyartasiev})";
        }

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public int Gyartasiev { get => gyartasiev; set => gyartasiev = value; }
        public DateOnly ForgalmiErvenyesseg { get => forgalmiErvenyesseg; set => forgalmiErvenyesseg = value; }
        public int Vetelar { get => vetelar; set => vetelar = value; }
        public int Kmallas { get => kmallas; set => kmallas = value; }
        public int Hengerurtartalom { get => hengerurtartalom; set => hengerurtartalom = value; }
        public int Tomeg { get => tomeg; set => tomeg = value; }
        public int Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }
    }
}
