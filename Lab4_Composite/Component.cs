using System;

namespace Lab4_Composite
{
    public abstract class Component
    {
        protected string name { get; private set; }

        protected Component(string name)
        {
            this.name = name;
        }

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }

        public abstract void Display(int depth);
    }
}