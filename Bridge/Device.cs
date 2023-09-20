using design_patterns.Bridge;
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

////Bridge Design Pattern 
////it is used when you have an hieracchy that can grow in two different dimension

//using design_patterns.Bridge;
//using System.Collections.Generic;

//var sony = new RemoteControl(new SonyTv());
//sony.TurnOn();
//sony.TurnOff();

////Console Result 
////Sony: Turn On
////Sony: Turn Off

//var sonyAdvance = new AdvancedRemoteControl(new SonyTv());
//sonyAdvance.TurnOn();
//sonyAdvance.SetChannel(5);
//sonyAdvance.TurnOff();

////Console Result 

////Sony: Turn On
////Sony: Set channel to 5
////Sony: Turn Off




//var samsung = new RemoteControl(new SamsungTv());
//samsung.TurnOn();
//samsung.TurnOff();

////Console Result 
////Samsung: Turn On
////Samsung: Turn Off

//var samsungAdvance = new AdvancedRemoteControl(new SamsungTv());
//samsungAdvance.TurnOn();
//samsungAdvance.SetChannel(10);
//samsungAdvance.TurnOff();

////Console Result 

////Samsung: Turn On
////Samsung: Set channel to 10
////Samsung: Turn Off
