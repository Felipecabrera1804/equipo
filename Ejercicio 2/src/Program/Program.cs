using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)// se manda a crear y almacenar los libros, manteniendo su simplicidad
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            libro1.AlmacenarLibro("A","7");
            libro2.AlmacenarLibro("B","3");

        }
    }
}
