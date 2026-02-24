using System;

class Coche
{
    public string color;

    public string ObtenerColor()
    {
        return color;
    }
}

class Program
{
    static void Main()
    {
        Coche miCoche = new Coche();
        miCoche.color = "Rojo";

        string resultado = miCoche.ObtenerColor();

        Console.WriteLine("El color del coche es: " + resultado);
    }
}
