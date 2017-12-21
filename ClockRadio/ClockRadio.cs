using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class ClockRadio
    {
        // member variables
        public bool isPowerOn;
        public Radio radio;
        public Alarm alarm;
        public Clock clock;
        // constructor
        public ClockRadio()
        {
            isPowerOn = false;
            alarm = new Alarm();
            clock = new Clock();
            radio = new Radio();
        }

        //member methods 
        public void DisplayPowerStatus()
        {
            if (isPowerOn)
            {
                Console.WriteLine("The Clock Radio is On");
            }
            else
            {
                Console.WriteLine("The Clock Radio is Off");
            }
        }
        public void TogglePower()
        {
            isPowerOn = !isPowerOn;

            DisplayPowerStatus();
        }
        public void runClockRadio()
        {
            TogglePower();
            alarm.ToggleAlarm();
            alarm.SetAlarm();
            clock.DisplayTime();
            clock.SetTime();

            radio.Dial();

        }
    }
}
