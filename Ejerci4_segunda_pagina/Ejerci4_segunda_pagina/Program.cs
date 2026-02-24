using System;

class Libro
{
    private string titulo;

    public Libro(string t)
    {
        titulo = t;
    }

    public void MostrarTitulo()
    {
        Console.WriteLine("El título del libro es: " + titulo);
    }
}

class Program
{
    static void Main()
    {
        Libro miLibro = new Libro("la naranja mecanica");
        miLibro.MostrarTitulo();
    }
}
