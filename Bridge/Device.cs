using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Bridge
{
    //This serves as the bridge between the feature and the implementation.
    public interface Device
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
       
    }
}
