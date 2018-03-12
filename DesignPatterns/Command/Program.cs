using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice newDevice = TVRemote.getDevice();
            TurnTVOn onCommand = new TurnTVOn(newDevice);
            DeviceButton onPressed = new DeviceButton(onCommand);
            onPressed.press();

            TurnTVOff offCommand = new TurnTVOff(newDevice);
            onPressed = new DeviceButton(offCommand);
            onPressed.press();

            TurnTVUp volUpCommand = new TurnTVUp(newDevice);
            onPressed = new DeviceButton(volUpCommand);
            onPressed.press();
            onPressed.press();
            onPressed.press();

            TurnTVDown volDownCommand = new TurnTVDown(newDevice);
            onPressed = new DeviceButton(volDownCommand);
            onPressed.press();


            Television tv = new Television();
            Radio radio = new Radio();
            List<IElectronicDevice> alldevices = new List<IElectronicDevice>();
            alldevices.Add(tv);
            alldevices.Add(radio);

            TurnItAllOff turnOffAll = new TurnItAllOff(alldevices);
            DeviceButton turnthemOff = new DeviceButton(turnOffAll);
            turnthemOff.press();
            turnthemOff.pressUndo();


            Console.ReadLine();
        }
    }
}
