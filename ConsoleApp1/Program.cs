﻿namespace ImplementacjaProstegofejsu
{
    public interface IDokument
{
    string Tytul { get; }
    DateTime DataUtworzenia { get; }
    void Wyswietl()
    {
        Console.WriteLine($"Tytuł: {Tytul}");
        Console.WriteLine($"Data utworzenia: {DataUtworzenia}");
    }
}
public class Faktura : IDokument
{
    public decimal Kwota { get; set; }
    public string Tytul => "Faktura";
    public DateTime DataUtworzenia => DateTime.Now;

    public void Wyswietl()
    {
        Console.WriteLine($"Tytuł: {Tytul}");
        Console.WriteLine($"Data utworzenia: {DataUtworzenia}");
        Console.WriteLine($"Kwota: {Kwota}");
    }
}
public class Raport : IDokument
{
    public string Autor { get; set; }
    public string Tytul => "Raport roczny";
    public DateTime DataUtworzenia => new DateTime(2025, 1, 15, 12, 30, 0);
    public void Wyswietl()
    {
        Console.WriteLine($"Tytuł: {Tytul}");
        Console.WriteLine($"Data utworzenia: {DataUtworzenia}");
        Console.WriteLine($"Autor: {Autor}");
    }

}

public class Email : IDokument
{
    public string Nadawca { get; set; }
    public string Tytul => "Email służbowy";
    public DateTime DataUtworzenia => new DateTime(2025, 12, 24, 18, 30, 0);
    public void Wyswietl()
    {
        Console.WriteLine($"Tytuł: {Tytul}");
        Console.WriteLine($"Data utworzenia: {DataUtworzenia}");
        Console.WriteLine($"Nadawca: {Nadawca}");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Witaj w programie!");
        List<IDokument> dokumenty = new List<IDokument>
                {
                    new Faktura { Kwota = 700.67m },
                    new Raport { Autor = "Jan Nowak" },
                    new Email { Nadawca = "makumbakrol@gmail.com" }
                };

        foreach (var dokument in dokumenty)
        {
            dokument.Wyswietl();
            Console.WriteLine();
        }
        Console.WriteLine($"\nPosortowane dokumenty według daty utworzenia:");
        Console.WriteLine($"----------------------------------------------\n");
        var posortowaneDokumenty = dokumenty.OrderBy(d => d.DataUtworzenia).ToList();
        foreach (var dokument in posortowaneDokumenty)
        {
            dokument.Wyswietl();
            Console.WriteLine();
        }


    }
}
    }