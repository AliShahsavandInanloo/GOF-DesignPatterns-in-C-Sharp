using System;

namespace DesignPatterns.TemplateMethod
{
    public class AuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Audit.");
        }
    }
}