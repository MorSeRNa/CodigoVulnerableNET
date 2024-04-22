using System;
using System.IO;

class PathDisclosure
{
    static void Main()
    {
        try
        {
            File.ReadAllText("/path/to/nonexistent/file.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer el archivo: {ex.Message}");
        }
    }
}
