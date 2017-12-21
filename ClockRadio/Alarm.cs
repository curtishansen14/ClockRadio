using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Alarm
    {
        // member variables
        public string alarmTime;
        public bool isAlarmOn;

        // constructor
        public Alarm()
        {
            isAlarmOn = false;
            alarmTime = "7:00 am";
        }

        //member methods 

        public void DisplayAlarm()
        {
            Console.WriteLine("Alarm is set for " + alarmTime + ".");
        }
        public void SetAlarm()
        {
            Console.WriteLine("Enter time for alarm ");
            alarmTime = Console.ReadLine();
        }

        public void ToggleAlarm()
        {
            isAlarmOn = !isAlarmOn;

            DisplayAlarmStatus();
        }
        public void DisplayAlarmStatus()
        {
            if (isAlarmOn)
            {
                Console.WriteLine("The Alarm is On");
            }
            else
            {
                Console.WriteLine("The Alarm is Off");
            }
        }
    }

}
  


