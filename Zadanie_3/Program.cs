namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperaturaCelsjusz = 25;
            double temperaturaFahrenheit = Math.Round((temperaturaCelsjusz * 9 / 5) + 32,2);
            double C = Math.Round((temperaturaFahrenheit - 32) * 5 / 9,2);
            if (C < 0) { 
                Console.WriteLine("Uwaga temperatura spada poniżej zera!");
            }
            Console.WriteLine($"Temperatura w Fahrenheitach: {temperaturaFahrenheit}");
            Console.WriteLine($"Temperatura w Celsjuszach: {C}");
        }
    }
}
