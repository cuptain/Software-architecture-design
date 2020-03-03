using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_Observer
{
    interface IObserver
    {
        void Update(ISubject subject);
    }
}
