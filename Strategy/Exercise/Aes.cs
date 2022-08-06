using System;

namespace DesignPatterns.Strategy.Exercise
{
    public class Aes : IEncryptionAlgorithm
    {
        public void Encrypt(string message)
        {
            Console.WriteLine("Encrypting using AES.");
        }
    }
}