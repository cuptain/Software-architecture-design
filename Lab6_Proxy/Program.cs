using System;
using System.Linq;

namespace Lab6_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Proxy();
            Component component1 = component.GetComponent(5);
            component1.GetFunction();
            Component component2 = component.GetComponent(3);
            component2.GetFunction();   
            component1 = component.GetComponent(1);
            component1.GetFunction();

            Console.Read();
        }
    }
}
