using System;
using System.IO;

class ErrorInseguro
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Introduce el nombre del archivo para leer:");
            string filename = Console.ReadLine();

            // Intenta leer el archivo especificado.
            string content = File.ReadAllText(filename);
            Console.WriteLine("Contenido del archivo:");
            Console.WriteLine(content);
        }
        catch (Exception ex)
        {
            // Imprime detalles del error, lo cual es inseguro.
            Console.WriteLine("Error al leer el archivo:");
            Console.WriteLine(ex.ToString());
        }
    }
}
