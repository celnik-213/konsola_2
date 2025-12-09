using System;
using System.Collections.Generic;

abstract class KontoBankowe
{
    public string NumerKonta { get; }
    public string Wlasciciel { get; }
    public decimal Saldo { get; protected set; }
    public KontoBankowe(string numerKonta, string wlasciciel)
    {
        NumerKonta = numerKonta;
        wlasciciel = wlasciciel;
        Saldo = 0;
    }
    public void Wplac(decimal kwota)
    {
        if (kwota > 0)
        {
            Saldo += kwota;
            Console.WriteLine($"Wpłacono {kwota}. Nowe saldo: {Saldo}");
        }
        else
        {
            Console.WriteLine("Kwota wpłaty musi być większa od zera.");
        }
    }
    public virtual void Wyplac(decimal kwota)
    {
        if (kwota > 0 && kwota <= Saldo)
        {
            Saldo -= kwota;
            Console.WriteLine($"Wypłacono {kwota}. Nowe saldo: {Saldo}");
        }
        else
        {
            Console.WriteLine("Niewystarczające środki lub nieprawidłowa kwota wypłaty.");
        }
    }
    public abstract decimal ObliczOprocentowanie();

    public virtual void WyswietlInformacje()
    {
        Console.WriteLine($"Konto: {NumerKonta}, Właściciel: {Wlasciciel}, Saldo: {Saldo}");
    }

}
class KontoOszczednosciowe : KontoBankowe
{
    public KontoOszczednosciowe(string numerKonta, string wlasciciel)
        : base(numerKonta, wlasciciel)
    {
    }
    public override decimal ObliczOprocentowanie()
    {
        return Saldo * 0.05m; 
    }
}
class KontoStudenckie : KontoBankowe
{
    public KontoStudenckie(string numerKonta, string wlasciciel)
        : base(numerKonta, wlasciciel)
    {
    }
    public override decimal ObliczOprocentowanie()
    {
        return Saldo * 0.02m; 
    }
}
class KontoFirmowe : KontoBankowe 
{
    public KontoFirmowe(string numerKonta, string wlasciciel)
        : base(numerKonta, wlasciciel)
    {
    }
    public override decimal ObliczOprocentowanie()
    {
        return 0; // Brak oprocentowania
    }
    public override void Wyplac(decimal kwota)
    {
        const decimal prowizja = 2m;
        decimal kwotaCalkowita = kwota + prowizja;
        if (kwotaCalkowita >= Saldo)
        {
            Saldo -= kwota;
            Console.WriteLine($"Wypłacono {kwota}. Nowe saldo: {Saldo}");
        }
        else
        {
            Console.WriteLine("Kwota wypłaty musi być większa od zera.");
        }
    }
    class Program
    {
        static void Main()
        {
            List<KontoBankowe> konta = new List<KontoBankowe>()
            {
                new KontoOszczednosciowe("12345678", "Jan Kowalski"),
                new KontoStudenckie("87654321", "Anna Nowak"),
                new KontoFirmowe("11223344", "XYZ Sp. z o.o.")
            };
            foreach (var konto in konta)
            {
                konto.Wplac(1000);
                decimal odsetki = konto.ObliczOprocentowanie();
                Console.WriteLine($"Oprocentowanie dla konta {konto.NumerKonta}: {odsetki} zł.");
                konto.WyswietlInformacje();
                Console.WriteLine();
            }
            Console.WriteLine("Test wypłaty z konta firmowego:");
            KontoFirmowe kontoFirmowe = (KontoFirmowe)konta[2];
            kontoFirmowe.Wyplac(100);
        }
    }
}
