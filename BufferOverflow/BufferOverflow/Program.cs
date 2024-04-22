using System;

class BufferOverflow
{
    static void Main()
    {
        Console.WriteLine("Introduce tu nombre:");
        char[] name = new char[10];
        int i = 0;
        foreach (char c in Console.ReadLine())
        {
            name[i++] = c; // Peligroso si la entrada es más larga que 10 caracteres
        }
        Console.WriteLine("Nombre almacenado.");
    }
}
