using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            SkaiciausIvedimas();
            Console.Read();
        }

        public static void SkaiciausIvedimas()
        {
            List<int> skaiciusarasas = new List<int>();
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            while (skaicius != 0)
            {
                skaiciusarasas.Add(skaicius);
            }
        }

        public static void SkaiciausIsvedimas()
        {

        }

        public void Isvedimas()
        {
            foreach (var ivestasskaicius in skaiciusarasas)
            {
                Console.WriteLine($"{skaicius}");
            }
        }
    }
}
