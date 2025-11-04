namespace Oceny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź ocenę: ");
            string ocena_string = Console.ReadLine();
            int ocena = int.Parse(ocena_string);
            string opis = "";
            if(ocena >=1 && ocena <=6)
            {
                switch(ocena)
                {
                    case 1:
                        opis = "Niedostateczny";
                        break;
                    case 2:
                        opis = "Dopuszczający";
                        break;
                    case 3:
                        opis = "Dostateczny";
                        break;
                    case 4:
                        opis = "Dobry";
                        break;
                    case 5:
                        opis = "Bardzo dobry";
                        break;
                    case 6:
                        opis = "Celujący";
                        break;
                }
                Console.WriteLine($"Ocena {ocena} to {opis}");
            }
            else
            {
                Console.WriteLine("Błąd: ocena musi być w zakresie 1-6");
            }   
        }
    }
}
