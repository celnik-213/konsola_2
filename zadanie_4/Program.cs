using System;

class Program
{
    static void Main()
    {
        string imie = "Anna";
        string nazwisko = "Kowalska";
        string wiekString = "28";
        string email = "anna.kowalska@example.com";
        string numerTelefonu = "123456789";

        bool imieOk = false;
        bool nazwiskoOk = false;
        bool wiekOk = false;
        bool emailOk = false;
        bool telefonOk = false;

        if (!string.IsNullOrWhiteSpace(imie))
        {
            imieOk = true;
            Console.WriteLine($"Imię: {imie}  OK");
        }
        else
        {
            Console.WriteLine("Imię X Błąd: Imię nie może być puste");
        }

        if (!string.IsNullOrWhiteSpace(nazwisko))
        {
            nazwiskoOk = true;
            Console.WriteLine($"Nazwisko: {nazwisko}  OK");
        }
        else
        {
            Console.WriteLine("Nazwisko X Błąd: Nazwisko nie może być puste");
        }

        if (int.TryParse(wiekString, out int wiek))
        {
            if (wiek >= 18 && wiek <= 100)
            {
                wiekOk = true;
                Console.WriteLine($"Wiek {wiek}  OK");
            }
            else
            {
                Console.WriteLine($"Wiek X Błąd: Wiek {wiek} jest poza zakresem 18–100");
            }
        }
        else
        {
            Console.WriteLine($"Wiek: {wiek} X Błąd: Wiek musi być liczbą");
        }

        if (email.Contains("@"))
        {
            emailOk = true;
            Console.WriteLine($"Email: {email} OK");
        }
        else
        {
            Console.WriteLine($"Email: {email} X Błąd: Adres email musi zawierać znak '@'");
        }

        if (numerTelefonu.Length == 9 && long.TryParse(numerTelefonu, out _))
        {
            telefonOk = true;
            Console.WriteLine($"Numer telefonu: {numerTelefonu}  OK");
        }
        else
        {
            Console.WriteLine($"Numer telefonu: {numerTelefonu} X Błąd: Numer musi mieć dokładnie 9 cyfr");
        }

        bool wszystkieOk = imieOk && nazwiskoOk && wiekOk && emailOk && telefonOk;

        Console.WriteLine();
        if (wszystkieOk)
        {
            Console.WriteLine("Wszystkie dane są poprawne. Rejestracja zakończona sukcesem!");
        }
        else
        {
            Console.WriteLine("Formularz zawiera błędy. Popraw dane i spróbuj ponownie.");
        }
    }
}