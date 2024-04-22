using System;
using System.Reflection;

class InsecureReflectionUsage
{
    static void Main()
    {
        Console.WriteLine("Introduce el nombre del método a invocar:");
        string methodName = Console.ReadLine();

        Type type = typeof(InternalMethods);
        MethodInfo methodInfo = type.GetMethod(methodName);
        if (methodInfo != null)
        {
            methodInfo.Invoke(null, null);
        }
        else
        {
            Console.WriteLine("Método no encontrado.");
        }
    }
}

public class InternalMethods
{
    public static void ShowSecret()
    {
        Console.WriteLine("Mostrando información secreta...");
    }

    public static void DeleteFiles()
    {
        Console.WriteLine("Borrando todos los archivos...");
    }
}
