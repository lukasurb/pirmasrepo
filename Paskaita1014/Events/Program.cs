using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank manobankas = new Bank("Danske Bank", 5468.62);

            manobankas.IdetiPinigai += Manobankas_IdetiPinigai;
            manobankas.BankoOperacija += Manobankas_BankoOperacija;
            manobankas.IsimtiPinigai += Manobankas_IsimtiPinigai;
            manobankas.PakeistaValiuta += Manobankas_PakeistaValiuta;

            manobankas.Deposit(1000);
            manobankas.Deposit(514.25);
            manobankas.Withdraw(2499.99);
            manobankas.Exchange(2550, "USD", 1.1567);
            manobankas.Exchange(50, "GBP", 0.84522);
            manobankas.Withdraw(2000);

            Console.ReadLine();
                }

        private static void Manobankas_PakeistaValiuta(object sender, string e)
        {
            Console.WriteLine(e);
        }

        private static void Manobankas_IsimtiPinigai(object sender, string e)
        {
            Console.WriteLine(e);
        }

        private static void Manobankas_BankoOperacija(object sender, string e)
        {
            Console.WriteLine(e);
        }

        private static void Manobankas_IdetiPinigai(object sender, string e)
        {
            Console.WriteLine(e);
        }
    }
}
