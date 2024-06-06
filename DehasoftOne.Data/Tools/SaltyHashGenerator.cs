using System;
using System.Security.Cryptography;
using System.Text;

namespace DehasoftOne.Data.Tools;

public class SaltyHashGenerator
{
    // Method to generate a salted hash
    public static string GenerateSaltyHash(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            // Generate salt using the input
            byte[] salt = GenerateSalt(input);

            // Convert the input to bytes
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // Combine the input bytes with the salt
            byte[] saltedInput = new byte[inputBytes.Length + salt.Length];
            Buffer.BlockCopy(inputBytes, 0, saltedInput, 0, inputBytes.Length);
            Buffer.BlockCopy(salt, 0, saltedInput, inputBytes.Length, salt.Length);

            // Compute the hash
            byte[] hashBytes = sha256.ComputeHash(saltedInput);
            string hash = Convert.ToBase64String(hashBytes);

            return hash;
        }
    }

    // Method to generate salt based on input
    private static byte[] GenerateSalt(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            // Use the input to generate the salt
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            return sha256.ComputeHash(inputBytes);
        }
    }
}

