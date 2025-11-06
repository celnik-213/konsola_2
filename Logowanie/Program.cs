namespace Logowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int logowanie = 0;
            string poprawne_haslo = "pass123";
            string poprawny_login = "admin";
            Console.WriteLine("Wprowadź login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Wprowadź haslo: ");
            string haslo = Console.ReadLine();
            while (logowanie < 3)
            {
                if (haslo == poprawne_haslo && login == poprawny_login)
                {
                    Console.WriteLine($"Zalogowano pomyślnie po prubie numer: {logowanie+1}");
                    break;
                }
                else
                {
                    logowanie++;
                    if (logowanie == 3)
                    {
                        Console.WriteLine("Konto zablokowane");
                        break;
                    }
                    Console.WriteLine("Błędne hasło lub login. Spróbuj ponownie.");
                    Console.WriteLine("Wprowadź login: ");
                    login = Console.ReadLine();
                    Console.WriteLine("Wprowadź haslo: ");
                    haslo = Console.ReadLine();
                }
            }
        }
    }
}
