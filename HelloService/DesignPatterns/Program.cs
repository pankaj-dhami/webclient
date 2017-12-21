using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Observable;
using DesignPatterns.Decorator;
using System.IO;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //observable pattern
            //WeatherStation weatherStation = new WeatherStation();
            //PhoneDisplay phoneDisplay = new PhoneDisplay(weatherStation);
            //weatherStation.Add(phoneDisplay);
            //WindowsDisplay windowsDisplay = new WindowsDisplay(weatherStation);
            //weatherStation.Add(windowsDisplay);
            //weatherStation.Notify();

            //decorator pattern
            // MainEntryPoint mainEntryPoint = new MainEntryPoint();

            PossibleSubStrings ps = new PossibleSubStrings();
            Console.Read();
        }
    }
}
