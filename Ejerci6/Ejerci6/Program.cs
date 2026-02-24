using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = ConvertirAFahrenheit(celsius);

        Console.WriteLine("La temperatura en Fahrenheit es: " + fahrenheit.ToString("F2"));
    }

    static double ConvertirAFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
}
