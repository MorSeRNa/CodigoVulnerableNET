using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class InsecureEncryption
{
    static void Main()
    {
        string textToEncrypt = "Texto secreto";
        string encryptedText = Encrypt(textToEncrypt);
        Console.WriteLine("Texto cifrado: " + encryptedText);
    }

    static string Encrypt(string plainText)
    {
        string key = "1234567812345678"; // Clave insegura y estática
        string iv = "1234567812345678"; // IV inseguro y estático

        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(key);
            aesAlg.IV = Encoding.UTF8.GetBytes(iv);

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                }
                return Convert.ToBase64String(msEncrypt.ToArray());
            }
        }
    }
}
