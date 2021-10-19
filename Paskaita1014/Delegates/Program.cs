using System;

namespace Delegates
{
    public delegate int DoOperation (int m1, int m2);

    class Program
    {
        private static DoOperation darytiVeiksma;

        static void Main(string[] args)
        {
            darytiVeiksma += MyMultiply;
            darytiVeiksma += MySum;
            darytiVeiksma += MySum;
            darytiVeiksma += MyMultiply;

            darytiVeiksma(16, 36);



            Console.ReadLine();
        }

        static int MyMultiply(int m1, int m2)
        {
            int sandauga = m1 * m2;
            Console.WriteLine(sandauga);
            return sandauga;
        }

        static int MySum(int m1, int m2)
        {
            int suma = m1 + m2;
            Console.WriteLine(suma);
            return suma;
        }
    }
}
