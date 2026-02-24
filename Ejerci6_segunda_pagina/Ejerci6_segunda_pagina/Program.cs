using System;

class Program
{
    static void Main()
    {
        var frutas = ("Manzana", "Banana", "Mango");
        var verduras = ("Zanahoria", "Lechuga", "Tomate");

        var combinadas = (
            frutas.Item1, frutas.Item2, frutas.Item3,
            verduras.Item1, verduras.Item2, verduras.Item3
        );

        Console.WriteLine("Tupla combinada:");
        Console.WriteLine(combinadas);
    }
}
