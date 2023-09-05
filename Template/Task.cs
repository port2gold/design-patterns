using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Template
{
    abstract class Task
    {
        private AuditTrail auditTrail;
        public Task()
        {
            this.auditTrail = new AuditTrail();
        }
        public void Execute() 
        {
            auditTrail.record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
