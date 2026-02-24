using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool esPar = EsPar(numero);

        if (esPar)
            Console.WriteLine("El número es par.");
        else
            Console.WriteLine("El número es impar.");
    }

    static bool EsPar(int n)
    {
        return n % 2 == 0;
    }
}
