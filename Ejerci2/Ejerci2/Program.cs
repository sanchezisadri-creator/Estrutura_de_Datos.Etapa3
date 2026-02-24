using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area = CalcularArea(radio);

        Console.WriteLine("El área del círculo es: " + area);
    }

    static double CalcularArea(double r)
    {
        return Math.PI * r * r;
    }
}
