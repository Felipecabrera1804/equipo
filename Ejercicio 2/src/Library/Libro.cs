using System;

namespace SRP
{
    public class Libro
    { // falta encapsular y separar metodos por clase, ya que no debe ser responsabilidad del libro almacenarse

        private string Titulo { get ; }
        private string Autor { get ; }
        private string Codigo { get ;  }
        private string SectorBiblioteca { get ; set; }
        private string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
