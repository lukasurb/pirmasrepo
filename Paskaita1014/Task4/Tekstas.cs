using System;
namespace Task4
{
    public class Tekstas
    {
        public Tekstas()
        {

        }

        public int TekstoIvedimas()
        {
            Console.Write("Iveskite teksta: ");
            string tekstas = Console.ReadLine();
            return tekstas;
        }

        }
    }
}
