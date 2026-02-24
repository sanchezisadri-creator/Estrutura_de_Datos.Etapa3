using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una cadena de texto: ");
        string texto = Console.ReadLine();

        int longitud = CalcularLongitud(texto);

        Console.WriteLine("La longitud de la cadena es: " + longitud);
    }

    static int CalcularLongitud(string cadena)
    {
        return cadena.Length;
    }
}
