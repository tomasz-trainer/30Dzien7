using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P09PobieraczFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderFlagi = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "flagi");
            Directory.CreateDirectory(folderFlagi);

            do
            {
                Console.WriteLine("Podaj skrót kraju (np. pl dla Polski, de dla Niemiec)");
                string kodKraju = Console.ReadLine().ToLower();

                string url = $"https://flagcdn.com/w2560/{kodKraju}.png";

                string nazwaPliku = Path.Combine(folderFlagi, $"{kodKraju}.png");

                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        //garbage collector

                        wc.DownloadFile(url, nazwaPliku);
                        Console.WriteLine("Pomyślnie pobrano flage");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nie udało się pobrać flagi. Sprawdź czy podałeś poprawny skrót kraju.");
                }


            } while (true);
        }
    }
}
