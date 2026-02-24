using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> lista = new List<string> { "a", "b", "c" };

        var tupla = (lista[0], lista[1], lista[2]);

        Console.WriteLine("Tupla ready: " + tupla);
    }
}
