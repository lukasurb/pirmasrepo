using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektasBudgetApp
{
    public class Prisijungimas : User
    {

        public static bool Jungtis()
        {
            string username, password;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Iveskite prisijungimo varda");
                    username = Console.ReadLine();
                    if (VartotojuSarasas.ContainsKey(username))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Vartotojas nerastas");
                        break;
                    }
                }

                VartotojuSarasas.TryGetValue(username, out string tempS);
                while (true)
                {
                    Console.WriteLine("Iveskite slaptazodi");
                    password = SkaitytiSlaptazodi();

                    if (password == tempS)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("KLAIDA: Neteisingas slaptazodis!");
                        Console.WriteLine("Prisijungti nepavyko");
                        return false;
                    }
                }
            }
        }

        public static bool Registruotis()
        {
            bool salyga = true;
            string tempVardas = null, tempSlaptazodis = null;


            while (salyga)
            {
                Console.WriteLine("Iveskite prisijungimo varda: ");
                tempVardas = Console.ReadLine();
                if (!VartotojuSarasas.ContainsKey(tempVardas))
                {
                    salyga = false;
                }
                else
                {
                    Console.WriteLine("Toks vardas jau egzistuoja.");
                }
            }
            salyga = true;

            while (salyga)
            {
                Console.WriteLine("Iveskite slaptazodi: ");
                tempSlaptazodis = SkaitytiSlaptazodi();
                if (tempSlaptazodis.Length <= 6)
                {
                    Console.WriteLine("Slaptazodis turi buti ilgesnis nei 6 simboliai");
                }
                else
                {
                    string tempSlaptazodis2;
                    Console.WriteLine("Pakartokite slaptazodi: ");
                    tempSlaptazodis2 = SkaitytiSlaptazodi();
                    if (tempSlaptazodis.Equals(tempSlaptazodis2))
                    {
                        salyga = false;
                    }
                    else
                    {
                        Console.WriteLine("Slaptazodziai nesutampa");
                    }
                }
            }

            try
            {
                    using (StreamWriter sw = File.AppendText(@"C:\Users\lukas\OneDrive\CodingSchool\repo\ProjektasBudgetApp\ProjektasBudgetApp\logininfo.csv"))
                    {
                        sw.Write(tempVardas);
                        sw.Write(";");
                        sw.WriteLine(tempSlaptazodis);
                    }
                    Console.WriteLine("Registracija sekimnga");
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ivyko problema");
                    Console.WriteLine(e.Message);
                    return false;
                }
            
        }


        public static string SkaitytiSlaptazodi()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        password = password.Substring(0, password.Length - 1);
                        int pos = Console.CursorLeft;
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }
    }
}
