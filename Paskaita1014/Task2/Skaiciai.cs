using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Skaiciai
    {
        public static List<int> SkaiciuSuvedimas()
        {
            List<int> manosarasas = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Iveskite skaiciu {i + 1}: ");
                string ivestis = Console.ReadLine();
                int skaicius = Convert.ToInt32(ivestis);
                manosarasas.Add(skaicius);
            }
            return manosarasas;
        }

        public static bool SarasasArTeigiamas(List<int> saraselis)
        {
            bool rezultatas = true;
            // 1, 2, -1, 5

            if (saraselis == null || saraselis.Count == 0)
            {
                rezultatas = false;
            }
            foreach (var skaicius in saraselis)
            {
                if (skaicius <= 0)
                {
                    rezultatas = false;
                }
            }
            return rezultatas;
        }

        public static void Suma(List<int> skaiciusarasas)
        {
            int suma = skaiciusarasas.Sum();
            Klaida(skaiciusarasas);
            Console.WriteLine($"Ivestu skaiciu suma - {suma}");
        }

        public static void Sandauga(List<int> skaiciusarasas)
        {
            int sandauga = 1;
            Klaida(skaiciusarasas);
            foreach (var skaicius in skaiciusarasas)
            {
                sandauga = sandauga * skaicius;
            }
            Console.WriteLine($"Ivestu skaiciu sandauga - {sandauga}");
        }

        public static void Dalmuo(List<int> sarasasskaiciu)
        {
            double dalmuo = 0;
            double daliklis = 1;

            foreach (var skaicius in sarasasskaiciu)
            {
                dalmuo = skaicius / daliklis;
                daliklis = dalmuo;
            }
            Klaida(sarasasskaiciu);
            Console.WriteLine($"Ivestu skaiciu dalmuo - {dalmuo}");
        }
        public static void Skirtumas()
        {

        }

        public static void Klaida(List<int> sarasas)
        {
            if (sarasas == null || sarasas.Count == 0)
            {
                Console.WriteLine("Klaida: Sarasas tuscias!");
            }
        }
    }
}
