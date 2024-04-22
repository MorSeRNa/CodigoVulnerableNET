using System;

public class InsecureRandomPasswordGenerator
{
    public static void Main()
    {
        Console.WriteLine("Generando contraseña insegura...");
        string password = GenerateTemporaryPassword();
        Console.WriteLine($"Contraseña Generada: {password}");
    }

    public static string GenerateTemporaryPassword()
    {
        Random rand = new Random();
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] stringChars = new char[8];

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[rand.Next(chars.Length)];
        }

        return new String(stringChars);
    }
}
