namespace DesignPatterns.TemplateMethod
{
    public abstract class Task
    {
        private readonly AuditTrail _auditTrail;

        protected Task()
        {
            this._auditTrail = new AuditTrail();
        }

        //protected Task(AuditTrail auditTrail)
        //{
        //    this._auditTrail = auditTrail;
        //}

        public void Execute()
        {
            this._auditTrail.Record();

            DoExecute();
        }

        protected abstract void DoExecute();
    }
}