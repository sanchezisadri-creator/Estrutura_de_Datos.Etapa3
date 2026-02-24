using System;

class Program
{
    static void Main()
    {
        int[] lista = { 5, 10, 15, 20, 25 };

        Console.Write("Ingrese un número : ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool encontrado = EstaEnLista(lista, numero);

        if (encontrado)
            Console.WriteLine("esta.");
        else
            Console.WriteLine("no esta.");
    }

    static bool EstaEnLista(int[] arreglo, int valor)
    {
        foreach (int elemento in arreglo)
        {
            if (elemento == valor)
                return true;
        }

        return false;
    }
}
