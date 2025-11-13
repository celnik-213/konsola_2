namespace Bankaccount
{
    internal class KontoBankowe
    {
        private decimal _saldo;
        private string _numerKonta;

        public KontoBankowe()
        {
            _saldo = 0;
            _numerKonta = Guid.NewGuid().ToString().Substring(0, 8);
        }

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public string NumerKonta
        {
            get { return _numerKonta; }
            set { _numerKonta = value; }
        }

        public void Wplata(decimal kwota)
        {
            if (kwota > 0)
            {
                _saldo += kwota;
                Console.WriteLine($"Wpłacono: {kwota}. Nowe saldo: {_saldo}");
            }
            else
            {
                Console.WriteLine("Kwota wpłaty musi być większa od zera.");
            }
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota > 0 && kwota <= _saldo)
            {
                _saldo -= kwota;
                Console.WriteLine($"Wypłacono: {kwota}. Nowe saldo: {_saldo}");
            }
            else
            {
                Console.WriteLine("Niewystarczające środki lub nieprawidłowa kwota wypłaty.");
            }
        }

        public void PokazSaldo()
        {
            Console.WriteLine($"Saldo konta ({_numerKonta}): {_saldo}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe konto = new KontoBankowe();

            while (true)
            {
                Console.WriteLine("\nWitaj w aplikacji bankowej! Wybierz opcję:");
                Console.WriteLine("1 - Wpłata");
                Console.WriteLine("2 - Wypłata");
                Console.WriteLine("3 - Pokaż saldo");
                Console.WriteLine("4 - Wyjście");
                Console.Write("Twój wybór: ");
                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        Console.Write("Podaj kwotę do wpłaty: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal kwotaWplaty))
                            konto.Wplata(kwotaWplaty);
                        else
                            Console.WriteLine("Nieprawidłowa kwota.");
                        break;

                    case "2":
                        Console.Write("Podaj kwotę do wypłaty: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal kwotaWyplaty))
                            konto.Wyplata(kwotaWyplaty);
                        else
                            Console.WriteLine("Nieprawidłowa kwota.");
                        break;

                    case "3":
                        konto.PokazSaldo();
                        break;

                    case "4":
                        Console.WriteLine("Dziękujemy za skorzystanie z aplikacji!");
                        return;

                    default:
                        Console.WriteLine("Nieprawidłowy wybór.");
                        break;
                }
            }
        }
    }
}