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
            

            var odpowiedź = Console.ReadLine();

            if (odpowiedź == "1")
            {
                Convert(new FarenheitConverter(), "farenheit");
               
            }
            else if (odpowiedź == "2")
            {
                Convert(new KelvinConverter(), "kelvin");
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

public interface IConverter
{
    double ConvertFromCelcius(double celcjusz);
}