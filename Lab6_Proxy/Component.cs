using System;

namespace Lab6_Proxy
{
    public abstract class Component
    {
        public int id;
        protected string name;
        protected DateTime date;

        public Component(int id, string name, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.date = date;
        }

        public virtual void GetFunction()
        {
            Console.WriteLine(id + ' ' + name + ' ' + date);
        }
    }
}