using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observable
{
    public class WeatherStation : IObservable
    {
        IList<IObserver> observers = new List<IObserver>();
        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public int GetTemperature()
        {
            return 1;
        }
    }
}
