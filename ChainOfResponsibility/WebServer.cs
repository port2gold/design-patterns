using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.ChainOfResponsibility
{
    public class WebServer
    {
        private Handler handler;

        public WebServer(Handler handler)
        {
            if(handler != null)
            {
                this.handler = handler;
            }
            
        }

        public void Handle(HttpRequest request)
        {
            handler.Handle(request); 
        }
    }
}
