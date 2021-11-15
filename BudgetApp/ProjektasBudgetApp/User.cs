using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjektasBudgetApp
{
    public class User
    {
        static protected Dictionary<string, string> VartotojuSarasas = new Dictionary<string, string>();
        static protected List<Transaction> transactions;

        public static bool DuomenuUzkrovimas()
        {
            string temp;
            string[] tempA;
            try
            {
                using (StreamReader sr = File.OpenText(@"C:\Users\lukas\OneDrive\CodingSchool\repo\ProjektasBudgetApp\ProjektasBudgetApp\logininfo.csv"))
                {
                    while((temp = sr.ReadLine()) != null)
                    {
                        tempA = temp.Split(';');
                        VartotojuSarasas.Add(tempA[0], tempA[1]);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Ivyko klaida: " + exc.Message);
                return false;
            }
            return true;
        }
    }
}





