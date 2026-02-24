using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resultado = Sumar(num1, num2);

        Console.WriteLine("La suma es: " + resultado);
    }

    static int Sumar(int a, int b)
    {
        return a + b;
    }
}
