using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Bridge
{
    public class SonyTv : Device
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine($"Sony: Set channel to {channel}");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony: Turn On");
        }
    }
}
