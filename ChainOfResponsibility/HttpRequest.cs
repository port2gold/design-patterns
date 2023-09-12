using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.ChainOfResponsibility
{
    public class HttpRequest
    {
        private readonly string username;
        private readonly string password;

        public HttpRequest(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string GetUsername()
        {
            return this.username;
        }
        public string GetPassword()
        {
            return this.password;
        }
    }
}
