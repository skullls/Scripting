using System;

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
}