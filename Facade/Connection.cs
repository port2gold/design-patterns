using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Facade
{
    public class Connection
    {
        public void Disconnect()
        {
            Console.WriteLine("Connection disconnected");
        }
    }
}
