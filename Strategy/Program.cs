namespace strategy
{
    using System;

    // Interfaz Estrategia para calcular el precio
    public interface IPrecioStrategy
    {
        double CalcularPrecio(double precioBase);
    }

    // Estrategia para tamaño pequeño
    public class PrecioPequeno : IPrecioStrategy
    {
        public double CalcularPrecio(double precioBase) => precioBase;
    }

    // Estrategia para tamaño mediano
    public class PrecioMediano : IPrecioStrategy
    {
        public double CalcularPrecio(double precioBase) => precioBase + 2.0;
    }

    // Estrategia para tamaño grande
    public class PrecioGrande : IPrecioStrategy
    {
        public double CalcularPrecio(double precioBase) => precioBase + 4.0;
    }

    // Clase Beverage usando la estrategia
    public abstract class Beverage
    {
        protected IPrecioStrategy _estrategiaPrecio;
        public void EstablecerEstrategia(IPrecioStrategy estrategia) => _estrategiaPrecio = estrategia;

        public abstract string Descripcion { get; }
        public double ObtenerCosto(double precioBase) => _estrategiaPrecio.CalcularPrecio(precioBase);
    }

    // Implementación de Cafe usando Strategy
    public class Cafe : Beverage
    {
        public override string Descripcion => "Café";

        public Cafe(IPrecioStrategy estrategia)
        {
            EstablecerEstrategia(estrategia);
        }
    }

    // Uso del patrón Strategy
    class Program
    {
        static void Main(string[] args)
        {
            IPrecioStrategy precioPequeno = new PrecioPequeno();
            IPrecioStrategy precioMediano = new PrecioMediano();
            IPrecioStrategy precioGrande = new PrecioGrande();

            Beverage cafePequeno = new Cafe(precioPequeno);
            Console.WriteLine($"{cafePequeno.Descripcion} pequeño cuesta {cafePequeno.ObtenerCosto(10.0)}");

            Beverage cafeMediano = new Cafe(precioMediano);
            Console.WriteLine($"{cafeMediano.Descripcion} mediano cuesta {cafeMediano.ObtenerCosto(10.0)}");

            Beverage cafeGrande = new Cafe(precioGrande);
            Console.WriteLine($"{cafeGrande.Descripcion} grande cuesta {cafeGrande.ObtenerCosto(10.0)}");
        }
    }

}
