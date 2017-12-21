using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockRadio myRadio = new ClockRadio();
            //normally would call the run function instead. 
            //myRadio.TogglePower();
            //myRadio.clock.DisplayTime();
            //myRadio.clock.SetTime();
            //myRadio.clock.DisplayTime();
            myRadio.runClockRadio();
            Console.ReadKey();
        }
    }
}
