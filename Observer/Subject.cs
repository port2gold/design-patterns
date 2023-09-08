using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Observer
{
    abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();
        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers(int value)
        {
            foreach (var observer in observers)
            {
                observer.Update(value);
            }
        }
    }
}
