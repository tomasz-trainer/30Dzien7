using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Intrefejsy
{
    internal class Krzeslo: IComparable
    {
        public string Firma { get; set; }   
        public int Waga { get; set; }

        public int CompareTo(object obj)
        {
            Krzeslo inneKrzeslo = (Krzeslo)obj;
            Krzeslo mojeKrzeslo = this;

            return mojeKrzeslo.Firma.Length - inneKrzeslo.Firma.Length;
            //return string.Compare(mojeKrzeslo.Firma, inneKrzeslo.Firma); // alfabetycznie
        }
    }
}
