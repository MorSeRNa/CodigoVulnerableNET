using System;
using System.Data.SqlClient;

class InsecureInputValidation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce tu número de teléfono:");
        string phoneNumber = Console.ReadLine();

        string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
        string query = $"INSERT INTO Users (PhoneNumber) VALUES ('{phoneNumber}')";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Número de teléfono guardado exitosamente.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar el número de teléfono: " + ex.Message);
        }
    }
}
