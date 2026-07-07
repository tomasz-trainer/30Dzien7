using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Statek.cs, Samolot.cs, Samochod.cs, Hydroplan.cs, Amfibia.cs

            // chcemy zrobić liste pojazdow, ktore umieją jeździć 

            List<IUmiejacyJezdzic> pojazdy = new List<IUmiejacyJezdzic>();

            pojazdy.Add(new Samochod());
            pojazdy.Add(new Amfibia());

            foreach (var p in pojazdy)
            {
                p.Jedz();
            }



        }
    }
}
