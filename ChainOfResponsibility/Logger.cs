using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.ChainOfResponsibility
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Logging");
            return false;
        }
    }
}
