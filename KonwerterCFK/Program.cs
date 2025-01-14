using System.ComponentModel.Design;

public class Konwerter
{

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Na co chcesz konwertować?");
            Console.WriteLine("1. Farenheity");
            Console.WriteLine("2. Kelviny");
            Console.WriteLine("3. Rankine");
            Console.WriteLine("4. Test Gita");


            var odpowiedź = Console.ReadLine();

            if (odpowiedź == "1")
            {
                Convert(new FarenheitConverter(), "farenheit");
               
            }
            else if (odpowiedź == "2")
            {
                Convert(new KelvinConverter(), "kelvin");
            }
            else if (odpowiedź== "3")
            {
                Convert(new RankineConverter(), "rankine");
            }
            else if (odpowiedź == "4")
            {
                Console.WriteLine("Testujemy gita");
            }
            else
            {
                throw new Exception("coś poszło nie tak");
            }
        }
        //dopisać trzeci konwerter który będzie konwertował z celcjusza do rankine


    }

   

    private static void Convert(IConverter converter, string conversionType)
    {
        Console.WriteLine("Podaj ile stopni celcjusza");

        if (double.TryParse(Console.ReadLine(), out double celcjusz))         //D ouble   ,  out...
        {
            double temperatura = converter.ConvertFromCelcius(celcjusz);
            Console.WriteLine($"Temperatura w {conversionType} wynosi :{temperatura}");
        }
        else
        {
            throw new Exception("musisz wpisać liczbę");
        }
    }

  
}

public class FarenheitConverter : IConverter
{
    public double ConvertFromCelcius(double celcjusz)
    {
        return (celcjusz * 9 / 5) + 32;
    }
}

public class KelvinConverter : IConverter
{
    public double ConvertFromCelcius(double celcjusz)
    {
        return celcjusz + 273.15;
    }
}


public class RankineConverter : IConverter
{
    public double ConvertFromCelcius(double celcjusz)
    {
        var rankineOdp = (celcjusz + 273.15) * 9 / 5;                    //12 C = 536,67 R
        return Math.Round(rankineOdp, 2);                                //10 C = 536,00 R
    }
}

public interface IConverter
{
    double ConvertFromCelcius(double celcjusz);
}