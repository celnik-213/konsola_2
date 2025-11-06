 public class KalkulaotrBMI
    {
        private double _wynikBMI;
        public double WynikBMI
        {
            get { return _wynikBMI; }
            set { _wynikBMI = value; }
        }
        public double obliczBMI(double waga, double wzrost)
        {
            wzrost = wzrost / 100;
            return waga / (wzrost * wzrost);
        }
        public string ocenaBMI(double bmi)
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
        
    }


internal class Program
{
    static void Main(string[] args)
    {

        var kalkulator = new KalkulaotrBMI(); 
        Console.WriteLine("Podaj swoją wagę w kilogramach: ");
        double waga = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj swój wzrost w centymetrach: ");
        double wzrost = double.Parse(Console.ReadLine());
        double bmi = kalkulator.obliczBMI(waga, wzrost);
        Console.WriteLine($"Twoje BMI wynosi: {bmi}");
        string wynik = kalkulator.ocenaBMI(bmi);
        Console.WriteLine($"Ocena BMI: {wynik}");

        kalkulator.WynikBMI = bmi;
        double wynikk = kalkulator.WynikBMI;


    }
}
