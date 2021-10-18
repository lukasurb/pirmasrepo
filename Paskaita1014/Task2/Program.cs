using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sarasas = Skaiciai.SkaiciuSuvedimas();
            if (Skaiciai.SarasasArTeigiamas(sarasas) == true)
            {
                Skaiciai.Suma(sarasas);
                Skaiciai.Sandauga(sarasas);
                Skaiciai.Dalmuo(sarasas);
            }
            Console.Read();
        }
    }
}
