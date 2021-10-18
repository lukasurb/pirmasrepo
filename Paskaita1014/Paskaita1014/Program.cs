using System;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            AgeCheck age = new AgeCheck();
            int amzius = age.AmziausIvedimas();
            Galimybes galimybe = age.AmziausPatikrinimas(amzius);
            IsvestiRez(galimybe);
            Console.Read();
        }

        public static void IsvestiRez(Galimybes galimybe)
        {
            switch (galimybe)
            {
                case Galimybes.Nieko:
                    Console.WriteLine("Vartotojas negali pirkti alko ir vairuoti");
                    break;
                case Galimybes.Vairuoti:
                    Console.WriteLine("Vartotojas negali pirkti alko, bet gali vairuoti");
                    break;
                case Galimybes.VairuotiirGerti:
                    Console.WriteLine("Vartotojas gali viska");
                    break;
            }
        }
    }
}
