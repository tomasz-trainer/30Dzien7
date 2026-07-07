using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Intrefejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 2, 5, 6, 3, 1 };

            int a  = 2;
            int x= a.CompareTo(5);

            Array.Sort(liczby);

            //   Array.Sort()

            Krzeslo[] krzesla = new Krzeslo[]
            {
                new Krzeslo{ Firma="yyyyy", Waga=1 },
                new Krzeslo{ Firma="xxx", Waga=3 },
                new Krzeslo{ Firma="zzzz", Waga=2 },
            };

            Array.Sort(krzesla);

            foreach (var k in krzesla)
            {
                Console.WriteLine(k.Firma + " " + k.Waga);
            }
        }
    }
}
