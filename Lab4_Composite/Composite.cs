using System.Collections.Generic;
using System;

namespace Lab4_Composite
{
    public class Composite : Component
    {
        public List<Component> children { get; }

        public Composite(string name) : base(name)
        {
            children = new List<Component>();
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override bool IsComposite()
        {
            return true;
        }

        public override void Display(int depth)
        {
            string output = "";
            for (int i = 0; i < depth; i++)
                output +=" ";
            Console.WriteLine(output + depth + ". " + name);

            foreach (Component c in children)
            {
                c.Display(depth + 1);
            }
        }
    }
}