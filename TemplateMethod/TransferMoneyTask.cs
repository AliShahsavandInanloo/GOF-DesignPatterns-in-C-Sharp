using System;

namespace DesignPatterns.TemplateMethod
{
    internal class TransferMoneyTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Transfer Money");
        }
    }
}