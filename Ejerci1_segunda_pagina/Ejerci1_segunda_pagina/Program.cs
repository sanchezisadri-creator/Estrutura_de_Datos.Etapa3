using System;

class Persona
{
    public string nombre;

    public void Saludar()
    {
        Console.WriteLine("Hola, soy " + nombre);
    }
}

class Program
{
    static void Main()
    {
        Persona persona1 = new Persona();
        persona1.nombre = "Isa";

        persona1.Saludar();
    }
}
