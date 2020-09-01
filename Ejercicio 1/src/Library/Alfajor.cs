using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        // cumple con ambos principios por solo encargarse de permitir la creacion de objetos y conocer sus datos
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}