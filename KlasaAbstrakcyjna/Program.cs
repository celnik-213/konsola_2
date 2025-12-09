using static System.Net.Mime.MediaTypeNames;

namespace KlasaAbstracyjna
{
    public abstract class KontoBankowe
    {
        public string numerKonta;
        public string wlasciciel;
        public decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            protected set { saldo = value; }
        }
        public KontoBankowe(string numerKonta, string wlasciciel)
        {
            this.numerKonta = numerKonta;
            this.wlasciciel = wlasciciel;
            this.saldo = 0;
        }

        public void wplac(decimal kwota)
        {
            saldo += kwota;
            Console.WriteLine($"Wpłacono {kwota} PLN. Nowe saldo: {saldo} PLN.");
        }

        public void wyplac(decimal kwota)
        {

        }

        public abstract decimal ObliczOprocentowanie();

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine($"Numer konta: {numerKonta}");
            Console.WriteLine($"Właściciel: {wlasciciel}");
            Console.WriteLine($"Saldo: {saldo} PLN");
        }

    }

    public class KontoOszczednosciowe : KontoBankowe
    {
        public string nazwaKonta = "Konto Oszczędnościowe";
        private float oprocentowanie = 0.05f;
        public KontoOszczednosciowe(string numerKonta, string wlasciciel)
            : base(numerKonta, wlasciciel)
        {

        }
        public override decimal ObliczOprocentowanie()
        {
            return saldo * (decimal)oprocentowanie;
        }
        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine($"Nazwa konta: {nazwaKonta}");
            Console.WriteLine($"Oprocentowanie: {oprocentowanie}%");
        }
    }

    public class KontoStudenckie : KontoBankowe
    {
        public string nazwaKonta = "Konto Studenckie";
        private float oprocentowanie = 0.02f;
        public KontoStudenckie(string numerKonta, string wlasciciel)
            : base(numerKonta, wlasciciel)
        {
        }
        public override decimal ObliczOprocentowanie()
        {
            return saldo * (decimal)oprocentowanie;
        }
        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine($"Nazwa konta: {nazwaKonta}");
            Console.WriteLine($"Oprocentowanie: {oprocentowanie}%");
        }
    }

    public class KontoFirmowe : KontoBankowe
    {
        public string nazwaKonta = "Konto Firmowe";
        private float oprocentowanie = 0;
        private int prowizja = 2;
        public KontoFirmowe(string numerKonta, string wlasciciel)
            : base(numerKonta, wlasciciel)
        {
        }
        public override decimal ObliczOprocentowanie()
        {
            return saldo * (decimal)oprocentowanie;
        }
        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine($"Nazwa konta: {nazwaKonta}");
            Console.WriteLine($"Oprocentowanie: {oprocentowanie}%");
        }

        new public void wyplac(decimal kwota)
        {
            decimal kwotaZProwizja = kwota + (kwota * (decimal)prowizja / 100);
            if (kwotaZProwizja > saldo)
            {
                Console.WriteLine("Niewystarczające środki na koncie.");
            }
            else
            {
                saldo -= kwotaZProwizja;
                Console.WriteLine($"Wypłacono {kwota} PLN z prowizją {prowizja}%. Nowe saldo: {saldo} PLN.");
            }
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}