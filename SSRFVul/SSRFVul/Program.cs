using System;
using System.Net;

class InsecureWebRequest
{
    static void Main()
    {
        Console.WriteLine("Introduce la URL para solicitar datos:");
        string url = Console.ReadLine();

        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        Console.WriteLine("Respuesta recibida.");
    }
}
