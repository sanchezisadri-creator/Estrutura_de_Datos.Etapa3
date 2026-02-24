using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int mayor = EncontrarMayor(num1, num2);

        Console.WriteLine("El número mayor es: " + mayor);
    }

    static int EncontrarMayor(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }
}
