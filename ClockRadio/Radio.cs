using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Radio
    {
        // member variables
        public string radioStation;
        public bool isRadioOn;
        public string userInput;

        // constructor
        public Radio()
        {
            radioStation = "Top 40";
            isRadioOn = false;
        }


        //member methods 
        public void DisplayStation()
        {
            Console.WriteLine("Radio Station is set for " + radioStation + ".");
        }
        public void Dial()
        {
            ToggleStation();
            switch (userInput)
            {
                case "1":
                    radioStation = "Top 40";
                    DisplayStation();
                    break;
                case "2":
                    radioStation = "Alternative";
                    DisplayStation();
                    break;
                case "3":
                    radioStation = "Icelandic Folk Revival";
                    DisplayStation();
                    break;
                default:
                    Console.WriteLine("Enter 1 2 or 3 to select station");
                    DisplayStation();
                    ToggleStation();
                    break;
            }
        }
            public string ToggleStation()
        {
            Console.WriteLine("Enter 1 2 or 3 to select station");
            userInput = Console.ReadLine();
            return userInput;


        }
    }
}
