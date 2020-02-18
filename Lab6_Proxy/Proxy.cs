using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6_Proxy
{
    public class Proxy : IComponent
    {
        List<Component> components;
        ComponentStore componentStore;
        public Proxy()
        {
            components = new List<Component>();
        }
        public Component GetComponent(int id)
        {
            Component component = components.FirstOrDefault(c => c.id == id);
            if(component == null)
            {
                if (componentStore == null)
                    componentStore = new ComponentStore();
                component = componentStore.GetComponent(id);
                components.Add(component);
            }
            return component;
        }
    }
}