using System;
namespace Events
{
    public class Bank
    {
        public string Pavadinimas;
        public double BankoBalansas;
        public double IskeistaValiuta;

        public Bank(string name, double balance)
        {
            Pavadinimas = name;
            BankoBalansas = balance;
        }

        public double Deposit(double suma)
        {
            BankoBalansas = BankoBalansas + suma;
            BankoOperacija?.Invoke(this, $"{Pavadinimas}: Buvo padarytas papildymas");
            IdetiPinigai?.Invoke(this, $"Jus papildete saskaita {suma} EUR. Jusu balansas {BankoBalansas} EUR");
            return BankoBalansas;
        }

        public double Withdraw(double suma)
        {
            BankoBalansas = BankoBalansas - suma;

            BankoOperacija?.Invoke(this, $"{Pavadinimas}: Buvo atliktas nurasymas");
            IsimtiPinigai?.Invoke(this, $"Jus isleidote {suma} EUR. Jusu balansas {BankoBalansas} EUR");
            return BankoBalansas;
        }

        public double Exchange(double suma, string valiuta, double valiutosKursas)
        {
            IskeistaValiuta = suma * valiutosKursas;
            BankoOperacija?.Invoke(this, $"{Pavadinimas}: Ivykdytas valiutos keitimas");
            PakeistaValiuta?.Invoke(this, $"Iskeitete EUR {suma} i {valiuta} {Math.Round(IskeistaValiuta)}");
            return IskeistaValiuta;
        }

        public event EventHandler<string> BankoOperacija;
        public event EventHandler<string> IdetiPinigai;
        public event EventHandler<string> IsimtiPinigai;
        public event EventHandler<string> PakeistaValiuta;



    }
}
