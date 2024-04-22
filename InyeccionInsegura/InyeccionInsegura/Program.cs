using System;
using System.Diagnostics;

class InsecureProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor, introduce una dirección IP para hacer ping:");
        string input = Console.ReadLine();

        try
        {
            Process.Start("cmd.exe", $"/c ping {input}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ejecutar el ping: " + ex.Message);
        }
    }
}

