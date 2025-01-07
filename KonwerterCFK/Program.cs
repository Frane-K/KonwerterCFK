using System.ComponentModel.Design;

public class Konwerter
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Na co chcesz konwertować?");
        Console.WriteLine("1. Farenheity");
        Console.WriteLine("2. Kelviny");


        var odpowiedź = Console.ReadLine();

        if (odpowiedź == "1")
        {
            Console.WriteLine("Podaj ile stopni celcjusza");



            if (double.TryParse(Console.ReadLine(), out double celcjusz))         //D ouble   ,  out...
            {
                double farenheit = CelcjuszNaFarenheita(celcjusz);
                Console.WriteLine($"Temperatura w stopniach farenheita wynosi :{farenheit}");
            }
            else
            {
                throw new Exception("musisz wpisać liczbę");
            }
        }
        else if (odpowiedź == "2")
        {
            Console.WriteLine("Podaj ile stopni celcjusza");



            if (double.TryParse(Console.ReadLine(), out double celcjusz))
            {
                double kelvin = CelcjuszNaKelvina(celcjusz);
                Console.WriteLine($"Temperatura w kelvinach wynosi :{kelvin}");
            }
            else
            {
                throw new Exception("musisz wpisać liczbę");
            }
        }
        else
        {
            throw new Exception("coś poszło nie tak");
        }



        
            


    }

    public static double CelcjuszNaFarenheita(double celcjusz)
    {
        return (celcjusz * 9 / 5) + 32;
    }


    public static double CelcjuszNaKelvina(double celcjusz)
    {
        return celcjusz + 273.15;
    }
    

}