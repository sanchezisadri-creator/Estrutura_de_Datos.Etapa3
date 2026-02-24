using System;

class Perro
{
    public string raza;

    public void MostrarRaza()
    {
        Console.WriteLine("La raza del perro es: " + raza);
    }
}

class Program
{
    static void Main()
    {
        Perro miPerro = new Perro();
        miPerro.raza = "Labrador";

        miPerro.MostrarRaza();
    }
}
