using System;

namespace Lab4_Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override bool IsComposite()
        {
            return false;
        }

        public override void Display(int depth)
        {
            string output = "";
            for (int i = 0; i < depth; i++)
                output +=" ";
            Console.WriteLine(output + depth + ". " + name);
        }
    }
}