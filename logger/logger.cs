using System;
using System.IO;

public class PatronLogger
{
    private static PatronLogger _instance;
    private static readonly object _lock = new object();
    private string _filePath;

    // Constructor privado 
    private PatronLogger(string filePath)
    {
        _filePath = filePath;
    }

    public static PatronLogger Instance(string filePath)
{
    // Verificar si la instancia ya existe
    if (_instance == null)
    {
        lock (_lock)
        {
            // Asegurarse de que sólo una instancia sea creada
            if (_instance == null)
            {
                _instance = new PatronLogger(filePath);
            }
        }
    }
    return _instance;
}

// METODO DE ESCRITURA
public void Write(string message)
{

    try
    {
        using (StreamWriter writer = new StreamWriter(_filePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error al escribir en el archivo: {ex.Message}");
    }
}

}

