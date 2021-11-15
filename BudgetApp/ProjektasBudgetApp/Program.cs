using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektasBudgetApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (User.DuomenuUzkrovimas())
            {
                if (JungtisRegistruotis())
                {
                    Console.WriteLine("Sveiki prisijunge!");
                    PradetiDarba();
                    List<Transaction> tranzakcijos = new List<Transaction>();
                    DirbtisuTranzakcijomis(tranzakcijos);
                    Console.WriteLine("Viso gero!");
                }

            }
            Console.Read();
        }

        public static void DirbtisuTranzakcijomis(List<Transaction> tranzakcijusarasas)
        {
            string pasirinkimas = Console.ReadLine();
            while (pasirinkimas != "4")
            {
                switch (pasirinkimas)
                {
                    case "1":
                        tranzakcijusarasas.Add(Transaction.SukurtiTranzakcija());
                        Console.Write("____________\nIveskite pasirinkima: ");
                        pasirinkimas = Console.ReadLine();
                        break;
                    case "2":
                        foreach (var item in tranzakcijusarasas)
                        {
                            Console.WriteLine($"{item.Date} | {item.Payee} | {item.Category} | {item.Reference} | {item.Amount}");
                        }
                        Console.Write("____________\nIveskite pasirinkima: ");
                        pasirinkimas = Console.ReadLine();
                        break;
                    case "3":
                        AtspausdintiTrx(tranzakcijusarasas);
                        Console.Write("____________\nIveskite pasirinkima: ");
                        pasirinkimas = Console.ReadLine();
                        break;
                    default:
                        Console.Write("____________\nIveskite pasirinkima: ");
                        pasirinkimas = Console.ReadLine();
                        break;
                }
            }
        }

        static bool JungtisRegistruotis()
        {
            Console.WriteLine("Pasirinkite norima veiksma: \n 1 - Prisijungti\n 2 - Registruotis");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1:
                    {
                        return Prisijungimas.Jungtis();
                    }
                case 2:
                    {
                        return Prisijungimas.Registruotis();
                    }
                default: return false;
            }
        }

        public static void PradetiDarba()
        {
            Console.WriteLine("Pasirinkite norima veiksma:");
            Console.WriteLine("1 - Ivesti nauja tranzakcija");
            Console.WriteLine("2 - Parodyti tranzakcijas ekrane");
            Console.WriteLine("3 - Issaugoti tranzakcijas faile");
            Console.WriteLine("4 - Baigti darba");
        }

        public static void AtspausdintiTrx(List<Transaction> transactionlist)
        {
            string filepath = @"C:\Users\lukas\OneDrive\CodingSchool\repo\ProjektasBudgetApp\ProjektasBudgetApp\Transactions\";
            string tranzakcijosfailas = Path.Combine(filepath, "transactions.csv");
            foreach (var item in transactionlist)
            {
                using (StreamWriter w = File.AppendText(tranzakcijosfailas))
                {
                    w.WriteLine($"{item.Date};{item.Payee};{item.Category};{item.Reference};{item.Amount}");
                }
            }
            Console.WriteLine("Tranzakcijos issaugotos");
        }

    }

}
