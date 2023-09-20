using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Bridge
{
    //Basic Remote Control (turnOn, turnOff)
    //Advanced Remote Control (setChannel)
    //Movie Remote Control (play, pause , rewind)
    public class RemoteControl
    {
        protected Device device;
        public RemoteControl(Device device)
        {
            this.device = device;
        }
        public void TurnOn()
        {
            this.device.TurnOn();
        }

        public void TurnOff()
        {
            this.device.TurnOff();
        }
    }
}
