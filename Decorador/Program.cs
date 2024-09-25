namespace Decorador
{
    using System;

    // Clase base Beverage
    public abstract class Beverage
    {
        public abstract string Descripcion { get; }
        public abstract double Costo();
    }

    // Clase concreta Cafe
    public class Cafe : Beverage
    {
        public override string Descripcion => "Café";

        public override double Costo() => 10.0;
    }

    // Clase base Decorador (hereda de Beverage)
    public abstract class DecoradorBebida : Beverage
    {
        protected Beverage _bebida;

        public DecoradorBebida(Beverage bebida)
        {
            _bebida = bebida;
        }

        public override string Descripcion => _bebida.Descripcion;
    }

    // Decorador concreto Leche
    public class Leche : DecoradorBebida
    {
        public Leche(Beverage bebida) : base(bebida) { }

        public override string Descripcion => _bebida.Descripcion + " con leche";

        public override double Costo() => _bebida.Costo() + 2.0;
    }

    // Decorador concreto Chocolate
    public class Chocolate : DecoradorBebida
    {
        public Chocolate(Beverage bebida) : base(bebida) { }

        public override string Descripcion => _bebida.Descripcion + " con chocolate";

        public override double Costo() => _bebida.Costo() + 3.0;
    }

    // Uso del Decorador
    class Program
    {
        static void Main(string[] args)
        {
            Beverage cafe = new Cafe();
            Console.WriteLine($"{cafe.Descripcion} cuesta {cafe.Costo()}");

            // Añadiendo leche
            cafe = new Leche(cafe);
            Console.WriteLine($"{cafe.Descripcion} cuesta {cafe.Costo()}");

            // Añadiendo chocolate
            cafe = new Chocolate(cafe);
            Console.WriteLine($"{cafe.Descripcion} cuesta {cafe.Costo()}");
        }
    }

}
