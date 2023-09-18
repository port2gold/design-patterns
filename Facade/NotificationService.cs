 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ip");
            var authtoken = server.Authenticate("appid", "key");
            server.Send(authtoken, new Message(message), target);
            connection.Disconnect()
        }
    }
}
