using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public interface IElectronicDevice
    {
        void on();
        void off();
        void volumeUp();
        void volumeDown();
    }

    public interface ICommand
    {
        void execute();
        void undo();
    }
    public class Television : IElectronicDevice
    {
        private int volume = 0;
        public void on()
        {
            Console.WriteLine("TV is On");
        }
        public void off()
        {
            Console.WriteLine("TV is Off");
        }

        public void volumeUp()
        {
            volume++;
            Console.WriteLine("TV Volume is at " +volume);
        }

        public void volumeDown()
        {
            volume--;
            Console.WriteLine("Volume is Down");
        }
    }
    public class Radio : IElectronicDevice
    {
        private int volume = 0;
        public void on()
        {
            Console.WriteLine("Radio is On");
        }
        public void off()
        {
            Console.WriteLine("Radio is Off");
        }

        public void volumeUp()
        {
            volume++;
            Console.WriteLine("Radio Volume is at " + volume);
        }

        public void volumeDown()
        {
            volume--;
            Console.WriteLine("Volume is Down");
        }
    }


    public class TurnTVOn : ICommand
    {
        IElectronicDevice theDevice;
        public TurnTVOn(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void execute()
        {
            theDevice.on();
        }
        public void undo()
        {
            theDevice.off();
        }
    }
    public class TurnTVOff : ICommand
    {
        IElectronicDevice theDevice;
        public TurnTVOff(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void execute()
        {
            theDevice.off();
        }
        public void undo()
        {
            theDevice.on();
        }
    }
    public class TurnTVUp : ICommand
    {
        IElectronicDevice theDevice;
        public TurnTVUp(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void execute()
        {
            theDevice.volumeUp();
        }
        public void undo()
        {
            theDevice.volumeDown();
        }
    }
    public class TurnTVDown : ICommand
    {
        IElectronicDevice theDevice;
        public TurnTVDown(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void execute()
        {
            theDevice.volumeDown();
        }
        public void undo()
        {
            theDevice.volumeUp();
        }
    }
    public class DeviceButton 
    {
        ICommand theCommand;
        public DeviceButton(ICommand newCommand)
        {
            theCommand = newCommand;
        }
        public void press()
        {
            theCommand.execute();
        }
        public void pressUndo()
        {
            theCommand.undo();
        }
    }

    public class TVRemote
    {
        public static IElectronicDevice getDevice()
        {
            return new Television();
        }
    }
    public class TurnItAllOff : ICommand
    {
        List<IElectronicDevice> theDevices;

        public TurnItAllOff(List<IElectronicDevice> newDevices) 
        {
            theDevices = newDevices;
        }

        public void execute()
        {
            foreach (IElectronicDevice device in theDevices)
                device.off();
        }
        public void undo()
        {
            foreach (IElectronicDevice device in theDevices)
                device.on();
        }
    }

}
