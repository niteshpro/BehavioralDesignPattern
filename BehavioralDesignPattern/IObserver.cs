using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBehavioralDesignPattern
{
    internal interface IObserver
    {
        void Update(float tempearure, float humidity);
    }
}
