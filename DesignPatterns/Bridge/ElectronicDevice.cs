using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public abstract class ElectronicDevice
    {
        public int deviceState;
        public int maxSetting;
        public int volumeSetting = 0;
        public abstract void buttonFivePressed();
        public abstract void buttonSixPressed();
        public void deviceFeedback()
        {
            if(deviceState>maxSetting|| deviceState<0)
            {
                deviceState = 0;
            }
            Console.WriteLine("On "+ deviceState);
        }

        public void buttonSevenPressed()
        {
            volumeSetting++;
            Console.WriteLine("Volume at " + volumeSetting);
        }
        public void buttonEightPressed()
        {
            volumeSetting--;
            Console.WriteLine("Volume at " + volumeSetting);
        }
    }

    public abstract class RemoteButton
    {
        private ElectronicDevice theDevice;
        public RemoteButton(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void buttonFivePressed()
        {
            theDevice.buttonFivePressed();
        }
        public void buttonSixPressed()
        {
            theDevice.buttonSixPressed();
        }
        public void deviceFeedback()
        {
            theDevice.deviceFeedback();
        }
       
        public abstract void buttonNinePressed();
    }

    public class TVDevice : ElectronicDevice
    {
        public TVDevice(int newDeviceState, int newMaxSetting)
        {
            deviceState = newDeviceState;
            maxSetting = newMaxSetting;
        }
        public override void buttonFivePressed()
        {
            Console.WriteLine("Channel Down");
            deviceState--;
            

        }
        public override void buttonSixPressed()
        {
            Console.WriteLine("Channel Up");
            deviceState++;
            
        }
    }
    public class TVRemoteMute : RemoteButton
    {
        public TVRemoteMute(ElectronicDevice newDevice)
            : base(newDevice)
        { }

        public override void buttonNinePressed()
        {
            Console.Write("TV is Muted");
        }
    }
    public class TVRemotePause : RemoteButton
    {
        public TVRemotePause(ElectronicDevice newDevice)
            : base(newDevice)
        { }

        public override void buttonNinePressed()
        {
            Console.Write("TV is Paused");
        }
    }
}
