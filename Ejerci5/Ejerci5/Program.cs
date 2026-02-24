using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una cadena de texto: ");
        string texto = Console.ReadLine();

        int cantidad = ContarVocales(texto);

        Console.WriteLine("La cantidad de vocales es: " + cantidad);
    }

    static int ContarVocales(string cadena)
    {
        int contador = 0;

        cadena = cadena.ToLower(); 

        foreach (char letra in cadena)
        {
            if (letra == 'a' || letra == 'e' || letra == 'i' ||
                letra == 'o' || letra == 'u')
            {
                contador++;
            }
        }

        return contador;
    }
}
