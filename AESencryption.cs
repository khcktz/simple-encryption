using System;
using System.Security.Cryptography;
using System.Text;

class SimpleAESEncryption
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple AES Encryption Tool");

        // Step 1: Generate a random key and IV
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.GenerateKey();
            aesAlg.GenerateIV();

            byte[] key = aesAlg.Key;
            byte[] iv = aesAlg.IV;

            Console.WriteLine("\nGenerated Key: " + Convert.ToBase64String(key));
            Console.WriteLine("Generated IV: " + Convert.ToBase64String(iv));

            // Step 2: Encrypt a message
            Console.Write("\nEnter a message to encrypt: ");
            string originalMessage = Console.ReadLine();

            byte[] encryptedMessage = EncryptStringToBytes_Aes(originalMessage, key, iv);
            Console.WriteLine("Encrypted Message: " + Convert.ToBase64String(encryptedMessage));

            // Step 3: Decrypt the message
            string decryptedMessage = DecryptStringFromBytes_Aes(encryptedMessage, key, iv);
            Console.WriteLine("Decrypted Message: " + decryptedMessage);
        }
    }

    static byte[] EncryptStringToBytes_Aes(string plainText, byte[] key, byte[] iv)
    {
        // Check arguments
        if (plainText == null || plainText.Length <= 0)
            throw new ArgumentNullException(nameof(plainText));
        if (key == null || key.Length <= 0)
            throw new ArgumentNullException(nameof(key));
        if (iv == null || iv.Length <= 0)
            throw new ArgumentNullException(nameof(iv));

        byte[] encrypted;

        // Create an Aes object with the specified key and IV
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = key;
            aesAlg.IV = iv;

            // Create an encryptor to perform the stream transform
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            // Create the streams used for encryption
            using (var msEncrypt = new System.IO.MemoryStream())
            {
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        // Write all data to the stream
                        swEncrypt.Write(plainText);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
        }

        return encrypted;
    }

    static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] key, byte[] iv)
    {
        // Check arguments
        if (cipherText == null || cipherText.Length <= 0)
            throw new ArgumentNullException(nameof(cipherText));
        if (key == null || key.Length <= 0)
            throw new ArgumentNullException(nameof(key));
        if (iv == null || iv.Length <= 0)
            throw new ArgumentNullException(nameof(iv));

        string plaintext = null;

        // Create an Aes object with the specified key and IV
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = key;
            aesAlg.IV = iv;

            // Create a decryptor to perform the stream transform
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            // Create the streams used for decryption
            using (var msDecrypt = new System.IO.MemoryStream(cipherText))
            {
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                    {
                        // Read the decrypted bytes from the decrypting stream
                        plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
        }

        return plaintext;
    }
}