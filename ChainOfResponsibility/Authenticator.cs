using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            var isValid = (request.GetUsername() == "admin" && request.GetPassword() == "1234");
            Console.WriteLine("Authentication");
            return !isValid;
            
        }
    }
}
