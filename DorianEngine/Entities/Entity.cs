using DorianEngine.Component;
using DorianEngine.Component.Components;
using System.Collections.Generic;
using System;

namespace DorianEngine.Entities
{
    public class Entity
    {
        // Child-parent system
        public Entity Parent;
        public List<Entity> Children;

        // Component system
        public List<BaseComponent> Components;

        // Common data
        public string Name;
        public Transform Transform;
        public Dictionary<string, object> CustomProperties;

        // Code for defining new entity
        public Entity(string name, Transform transform)
        {
            // If user magically forgot to supply a name, give it at least something
            if(name.Length == 0)
            {
                Name = (DateTime.Now.Year + DateTime.Now.Ticks).ToString();
            }
            // Else just give the supplied name
            else
            {
                Name = name;
            }

            Transform = transform;
            Components = new List<BaseComponent>();
            Children = new List<Entity>();
        }

        public T AddComponent<T>(T component) where T : BaseComponent
        {
            component.Entity = this;
            Components.Add(component);
            return component;
        }

        public T RemoveComponent<T>(T component) where T : BaseComponent
        {
            component.Entity = null;
            Components.Remove(component);
            return null;
        }

        public T GetComponent<T>() where T : BaseComponent
        {
            foreach (BaseComponent component in Components)
            {
                bool test = component is T;

                if (test)
                {
                    return (T)component;
                }
            }
            return null;
        }


        /*public BaseComponent GetComponent(BaseComponent component)
        {
            foreach(BaseComponent baseComponent in Components)
            {
                if(baseComponent is component)
                {
                    return baseComponent;
                }
            }

            return null;
        }*/

        public void AddChild(Entity child)
        {
            child.Parent = this;
            Children.Add(child);
        }

        public List<Entity> GetChildren()
        {
            List<Entity> _children = new List<Entity>(Enumerate());

            return _children;
        }

        public Entity GetChildByName(string name)
        {
            foreach (Entity entity in Children)
            {
                if (entity.Name == name)
                {
                    return entity; // Return entity if it's name equals given parameter
                }
            }

            return null; // Else return nothing
        }

        // Thank you Fireboyd78 for writing this, I couldn't figure it out myself
        public IEnumerable<Entity> Enumerate()
        {
            foreach (Entity child in Children)
            {
                yield return child;
                foreach (Entity grandchild in child.Enumerate())
                {
                    yield return grandchild;
                }
            }
        }
    }
}
