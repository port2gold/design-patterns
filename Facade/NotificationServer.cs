using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Facade
{
    public class NotificationServer
    {
        //connect() -> Connection
        //authenticate (appId, key)  -> AuthToken
        //Send(authToken, message, target)
        // conn.disconnect()

        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }
        public AuthToken Authenticate(string appID, string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken authToken, Message message, string target) 
        {
            Console.WriteLine("Sending a message");
        }
    }
}
