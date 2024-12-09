using System;
using System.Security.Cryptography;
using System.Text;

namespace Business
{
    public class Bresources
    {
        public static string ConvertirSha256(string texto)
        {
            // Validación de entrada
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentException("El texto no puede ser nulo o vacío.", nameof(texto));
            }

            try
            {
                // Crear una instancia de SHA256
                using (SHA256 hash = SHA256.Create())
                {
                    // Convertir el texto en bytes
                    byte[] bytes = Encoding.UTF8.GetBytes(texto);

                    // Calcular el hash
                    byte[] result = hash.ComputeHash(bytes);

                    // Convertir el hash en un string hexadecimal
                    StringBuilder sb = new StringBuilder(result.Length * 2); // Optimizado para mejorar la capacidad del StringBuilder
                    foreach (byte b in result)
                    {
                        sb.Append(b.ToString("x2"));
                    }

                    return sb.ToString();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepción
                Console.WriteLine($"Error: {ex.Message}");
                throw; // Volver a lanzar la excepción
            }
        }


    }
}