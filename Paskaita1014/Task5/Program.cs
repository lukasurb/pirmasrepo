using System;
using System.IO;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        { 
            string ivestiduomenys = IvestiDuomenis();
            IrasytiDuomenis(ivestiduomenys);
        }

        public static string IvestiDuomenis()
        {
            Console.WriteLine("Irasykite duomenis");
            string data = Console.ReadLine();
            return data;
        }

        public static void IrasytiDuomenis(string duomenys)
        {
            string vieta = "/Users/lukasurb/failas.txt";
            DirectoryInfo direktorija = Directory.GetParent(vieta);
            if (direktorija.Exists == true)
            {
                File.WriteAllText(vieta, duomenys);
            }
            else
            {
                Console.WriteLine("Ivyko klaida, vieta neegzistuoja");
            }
        }
    }
}
