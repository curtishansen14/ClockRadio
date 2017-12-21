using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Clock
    {
     // member variables
        public string currentTime;
        // constructor
        public Clock()
        {
            currentTime = "12:00";
        }
     
     //member methods 
     public void DisplayTime()
        {
            Console.WriteLine("Current time is " + currentTime + ".");
        }
     public void SetTime()
        {
            Console.WriteLine("Please enter new time ");
            currentTime = Console.ReadLine();
        }
    }
}
