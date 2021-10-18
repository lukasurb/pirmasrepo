using System;
using System.Collections.Generic;

namespace Task3
{
    public class InputOutput
    {
        private static void Input()
        {
            List<int> manoSarasas = new List<int>();
            bool noriuTesti = true;

            while (noriuTesti)
            {
                Console.WriteLine("Iveskite skaiciu:");
                string ivestis = Console.ReadLine();
                int skaicius = Convert.ToInt32(ivestis);

                if (skaicius == 0)
                {
                    break;
                }

                manoSarasas.Add(skaicius);

                noriuTesti = Console.ReadLine() != 0 ;
            }
        }
    }
}
