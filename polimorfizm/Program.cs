using System;
using System.Collections.Generic;
using System.Linq;

public interface IDokument
{
    string Tytul { get; }
    DateTime DataUtworzenia { get; }
    void Wyswietl();
}

public class Faktura : IDokument
{
    public string Tytul { get; }
    public DateTime DataUtworzenia { get; }
    public decimal Kwota { get; }

    public Faktura(string tytul, DateTime data, decimal kwota)
    {
        Tytul = tytul;
        DataUtworzenia = data;
        Kwota = kwota;
    }

    public void Wyswietl()
    {
        Console.WriteLine($"[Faktura] {Tytul}, Data: {DataUtworzenia}, Kwota: {Kwota} zł");
    }
}

public class Raport : IDokument
{
    public string Tytul { get; }
    public DateTime DataUtworzenia { get; }
    public string Autor { get; }

    public Raport(string tytul, DateTime data, string autor)
    {
        Tytul = tytul;
        DataUtworzenia = data;
        Autor = autor;
    }

    public void Wyswietl()
    {
        Console.WriteLine($"[Raport] {Tytul}, Data: {DataUtworzenia}, Autor: {Autor}");
    }
}

public class Email : IDokument
{
    public string Tytul { get; }
    public DateTime DataUtworzenia { get; }
    public string Nadawca { get; }

    public Email(string tytul, DateTime data, string nadawca)
    {
        Tytul = tytul;
        DataUtworzenia = data;
        Nadawca = nadawca;
    }

    public void Wyswietl()
    {
        Console.WriteLine($"[Email] {Tytul}, Data: {DataUtworzenia}, Nadawca: {Nadawca}");
    }
}

class Program
{
    static void Main()
    {
        List<IDokument> dokumenty = new List<IDokument>
        {
            new Faktura("Faktura #12", new DateTime(2023, 4, 2), 1200.50m),
            new Raport("Raport kwartalny", new DateTime(2023, 3, 15), "Jan Kowalski"),
            new Email("Powiadomienie", new DateTime(2023, 4, 10), "admin@firma.pl")
        };

        Console.WriteLine("--- Dokumenty przed sortowaniem ---");
        foreach (var d in dokumenty)
            d.Wyswietl();

        dokumenty = dokumenty.OrderBy(d => d.DataUtworzenia).ToList();

        Console.WriteLine("\n--- Dokumenty po sortowaniu ---");
        foreach (var d in dokumenty)
            d.Wyswietl();
    }
}
