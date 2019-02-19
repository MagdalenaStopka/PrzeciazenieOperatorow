using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przecizazenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Towar t1 = new Towar() { Cena = 100, Nazwa = "komputer" };
            Towar t2 = new Towar() { Cena = 120, Nazwa = "monitor" };
            Towar t3 = new Towar() { Cena = 130, Nazwa = "komputer" };

            //jesli bez equals, to wyrażęnie t1.Equals(t3) da false
            bool result = t1.Equals(t3);
            var result3 = t1 == t3;
            var result2 = t1 + t3;
            var resultxxx = t1 != t2;
            var resultxxxx = t1 != t3; // false, bo t1 ma taka sama nazwe jak t3
        }
    }

    class Towar
    {
        public int Cena { get; set; }
        public string Nazwa { get; set; }

        public override bool Equals(object obj)
        {
            var towar = obj as Towar;
            if (towar is null)
                return false;

            return towar.Nazwa == this.Nazwa;
        }

        public static int operator +(Towar b, Towar c)
        {
            return b.Cena + c.Cena;
        }

        public static int operator -(Towar a, Towar c)
        {
            return a.Cena - c.Cena;
        }

        public static bool operator ==(Towar a, Towar c)
        {
            return a.Nazwa == c.Nazwa;
        }

        public static bool operator !=(Towar a, Towar c)
        {
            return !(a == c);
        }


    }
}
