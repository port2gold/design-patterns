using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Bridge
{
    public class SamsungTv : Device
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("Samsung: Turn Off");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung: Turn On");
        }
    }
}
