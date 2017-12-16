using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observable
{
    public class PhoneDisplay : IObserver, IDisplay
    {
        private IObservable weatherStation;

        public PhoneDisplay(IObservable weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("" + typeof(PhoneDisplay) + weatherStation.GetTemperature());
        }
    }
    public class WindowsDisplay : IObserver, IDisplay
    {
        private IObservable weatherStation;

        public WindowsDisplay(IObservable weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("" + typeof(WindowsDisplay) + weatherStation.GetTemperature());
        }
    }
}
