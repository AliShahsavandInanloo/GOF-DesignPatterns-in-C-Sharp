using System;

namespace DesignPatterns.Strategy.Exercise
{
    public class Des : IEncryptionAlgorithm
    {
        public void Encrypt(string message)
        {
            Console.WriteLine("Encrypting using DES.");
        }
    }
}