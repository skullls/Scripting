using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Obtener instancia.
        PatronLogger logger = PatronLogger.Instance("log.txt");
        
        // Escribir mensaje
        logger.Write("SegundaPrueba2222");

        // Mensaje de confirmación
        Console.WriteLine("Mensaje registrado en el archivo de log.");
    }
}