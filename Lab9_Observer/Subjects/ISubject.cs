using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_Observer
{
    interface ISubject
    {
        public void Attach(IObserver observer);

        public  void Detach(IObserver observer);

        public  void Notify();
    }
}
