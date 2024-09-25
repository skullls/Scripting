namespace LSP
{
    // Clase base Vehiculo
    public class Vehiculo
    {
        public virtual void Avanzar()
        {
            Console.WriteLine("El vehículo está avanzando.");
        }
    }

    // Clase derivada Coche que extiende Vehiculo
    public class Coche : Vehiculo
    {
        public override void Avanzar()
        {
            Console.WriteLine("El coche está avanzando.");
        }
    }

    // Clase derivada Bicicleta que extiende Vehiculo
    public class Bicicleta : Vehiculo
    {
        public override void Avanzar()
        {
            Console.WriteLine("La bicicleta está avanzando.");
        }
    }

    // Clase principal que usa el principio LSP
    class Program
    {
        static void Main()
        {
            Vehiculo vehiculo1 = new Coche();
            Vehiculo vehiculo2 = new Bicicleta();

            MoverVehiculo(vehiculo1);  // El coche está avanzando.
            MoverVehiculo(vehiculo2);  // La bicicleta está avanzando.
        }

        static void MoverVehiculo(Vehiculo vehiculo)
        {
            vehiculo.Avanzar();
        }
    }

}
