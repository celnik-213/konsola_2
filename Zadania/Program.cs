namespace Zadania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź ilość zadań od 1-20: ");
            string zadanie_string = Console.ReadLine();
            int zadanie = int.Parse(zadanie_string);
            string opis = "";
            if (zadanie >= 1 && zadanie <= 20) { 
                for(int i = 1; i <= zadanie; i++)
                {
                    if (i%2 == 0)
                    {
                        Console.WriteLine($"Zadanie {i} - Priorytet normlany");
                    }
                    else
                    {
                      Console.WriteLine($"Zadanie {i} - Priorytet wysoki");
                    }
                }
            }
        }
    }
}
