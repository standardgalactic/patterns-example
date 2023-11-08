using System;
using System.Collections.Generic;

namespace Patterns.Structural.Composite.Menu;
    public class Menu : MenuComponent
    {
        private List<MenuComponent> _components = new ();
        public override string Name { get; }

        public override string Description { get; }
        public Menu(string name, string description)
        {
            Name = name;
            Description = description;

        }

        public override void Add(MenuComponent component)
        {
            _components.Add(component);
        }

        public override void Remove(MenuComponent component) {
            _components.Remove(component);
        }

        public override MenuComponent GetChild(int i) {
            return  _components[i];
        }

     
        public override void Print() {
            Console.WriteLine(Name);
            Console.WriteLine("___________");
            foreach (var menuComponent in _components)
            {
                menuComponent.Print();
            }
            Console.WriteLine();
        }
    
}