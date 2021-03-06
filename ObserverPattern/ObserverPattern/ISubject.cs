﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
   public interface ISubject
    {
        void Register(IObserver o);
        void Unregister(IObserver o);
        void NotifyObserver();
    }
}
