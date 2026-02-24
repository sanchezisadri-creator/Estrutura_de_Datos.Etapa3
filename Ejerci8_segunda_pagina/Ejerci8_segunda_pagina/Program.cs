using System;

class Program
{
    static void Main()
    {
        var tupla = (65, 650, 305, 450, 2350);

        int longitud = tupla.GetType().GetFields().Length;

        Console.WriteLine("La longitud de la tupla es: " + longitud);
    }
}
