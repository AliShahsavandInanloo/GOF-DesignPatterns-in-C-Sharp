using System;

namespace DesignPatterns.TemplateMethod
{
    public class GenerateReportTask : Task
    {
        private readonly AuditTrail _auditTrail;


        protected override void DoExecute()
        {
            Console.WriteLine("Generate Report");
        }
    }
}