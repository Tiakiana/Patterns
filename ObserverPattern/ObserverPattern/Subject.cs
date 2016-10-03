using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class Subject : ISubject
    {
        List<IObserver> listOfObservers = new List<IObserver>();

        public void NotifyObserver()
        {
            foreach (IObserver item in listOfObservers)
            {
                item.Update();
            }
        }

        public void Register(IObserver o)
        {
            listOfObservers.Add(o);
        }

        public void Unregister(IObserver o)
        {
            listOfObservers.Remove(o);
        }
    }
}
