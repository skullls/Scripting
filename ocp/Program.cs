// Clase abstracta Forma (abierta para extensión)
public abstract class Forma
{
    public abstract double Area();
}

// Clase Círculo que extiende Forma
public class Circulo : Forma
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double Area()
    {
        return Math.PI * Radio * Radio;
    }
}

// Clase Rectángulo que extiende Forma
public class Rectangulo : Forma
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public override double Area()
    {
        return Ancho * Alto;
    }
}

// Clase principal para aplicar el OCP
class Program
{
    static void Main()
    {
        Forma circulo = new Circulo(5);
        Forma rectangulo = new Rectangulo(4, 6);

        Console.WriteLine("Área del círculo: " + circulo.Area());
        Console.WriteLine("Área del rectángulo: " + rectangulo.Area());
    }
}
