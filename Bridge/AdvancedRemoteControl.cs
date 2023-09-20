using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {

        public AdvancedRemoteControl(Device device) : base(device) { }
        
        public void SetChannel(int number)
        {
            device.SetChannel(number);
        }
    }
}
