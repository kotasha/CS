using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteButton theTVMute = new TVRemoteMute(new TVDevice(1, 200));
            RemoteButton theTVPaused = new TVRemotePause(new TVDevice(1, 200));

            Console.WriteLine("Test TV with Mute");
            theTVMute.buttonFivePressed();
            theTVMute.buttonSixPressed();
            theTVMute.buttonNinePressed();

            Console.WriteLine("Test TV with Pause");
            theTVPaused.buttonFivePressed();
            theTVPaused.buttonSixPressed();
            theTVPaused.buttonSixPressed();
            theTVPaused.buttonSixPressed();
            theTVPaused.buttonNinePressed();
            Console.WriteLine();
            theTVPaused.deviceFeedback();


            Console.Read();

        }
    }
}
