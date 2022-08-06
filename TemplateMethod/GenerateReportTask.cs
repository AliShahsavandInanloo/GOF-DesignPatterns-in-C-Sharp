using System;

namespace DesignPatterns.TemplateMethod
{
    public class GenerateReportTask
    {
        private readonly AuditTrail _auditTrail;

        public GenerateReportTask(AuditTrail auditTrail)
        {
            this._auditTrail = auditTrail;
        }

        public void Execute()
        {
            this._auditTrail.Record();

            Console.WriteLine("Generate Report");
        }
    }
}