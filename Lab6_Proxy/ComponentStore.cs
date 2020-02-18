using System.Collections.Generic;
using System.Linq;
using System;

namespace Lab6_Proxy
{
    public class ComponentStore : IComponent
    {
        ComponentContext container;
        public ComponentStore()
        {
            container = new ComponentContext();
        }
        public Component GetComponent(int id)
        {
            return container.Components.FirstOrDefault(c => c.id == id);
        }
    }
}