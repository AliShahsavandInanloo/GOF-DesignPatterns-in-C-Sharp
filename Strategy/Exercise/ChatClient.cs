using System;

namespace DesignPatterns.Strategy.Exercise
{
    internal class ChatClient
    {
        public void Send(string message, IEncryptionAlgorithm encryptor)
        {
            encryptor.Encrypt(message);
            Console.WriteLine("Sending the encrypted message...");
        }
    }
}