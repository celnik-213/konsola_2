namespace BMI
{
   class KalkulaotrBMI
    {
        public static double obliczBMI(double waga, double wzrost)
        {
            wzrost = wzrost / 100;
            return waga / (wzrost * wzrost);
        }
        public static string ocenaBMI(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Niedowaga";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Waga prawidłowa";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Nadwaga";
            }
            else
            {
                return "Otyłość";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoją wagę w kilogramach: ");
            double waga = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost w centymetrach: ");
            double wzrost = double.Parse(Console.ReadLine());
            double bmi = obliczBMI(waga, wzrost);
            Console.WriteLine($"Twoje BMI wynosi: {bmi}");
            string wynik = ocenaBMI(bmi);
            Console.WriteLine($"Ocena BMI: {wynik}");

        }
    }
}
