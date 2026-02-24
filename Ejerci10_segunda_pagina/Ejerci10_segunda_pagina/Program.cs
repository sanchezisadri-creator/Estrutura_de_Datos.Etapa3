using System;

class Program
{
    static void Main()
    {
        var numeros = (2, 4, 2, 6, 2, 8);

        Console.Write("Ingrese el número a buscar: ");
        int buscar = Convert.ToInt32(Console.ReadLine());

        int contador = 0;

        if (numeros.Item1 == buscar) contador++;
        if (numeros.Item2 == buscar) contador++;
        if (numeros.Item3 == buscar) contador++;
        if (numeros.Item4 == buscar) contador++;
        if (numeros.Item5 == buscar) contador++;
        if (numeros.Item6 == buscar) contador++;

        Console.WriteLine("El número aparece " + contador + " veces.");
    }
}
