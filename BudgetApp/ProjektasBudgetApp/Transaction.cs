using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektasBudgetApp
{
    public class Transaction
    {
        public string Date;
        public string Payee;
        public string Category;
        public string Reference;
        public double Amount;

        public Transaction(string data, string moketojas, string kategorija, string tekstas, double suma)
        {
            Date = data;
            Payee = moketojas;
            Category = kategorija;
            Reference = tekstas;
            Amount = suma;
        }

        public static Transaction SukurtiTranzakcija()
        {
            Console.Write("Mokejimo data: ");
            string data = Console.ReadLine();
            Console.Write("Moketojas: ");
            string moketojas = Console.ReadLine();
            Console.Write("Kategorija: ");
            string kategorija = Console.ReadLine();
            Console.Write("Tekstas: ");
            string tekstas = Console.ReadLine();
            Console.Write("Suma: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Transaction tranzakcija = new Transaction(data, moketojas, kategorija, tekstas, amount);
            return tranzakcija;
        }
    }
}
