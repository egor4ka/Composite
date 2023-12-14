using Composite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    internal abstract class MenuComponent
    {
        protected string name;
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();
        public MenuComponent(string name)
        {
            this.name = name;
        }

        public virtual void Add(MenuComponent component)

        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Блюда не существует");
            }
            _menuComponents.Add(component);
        }

        public virtual void Remove(MenuComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component));
            }
            if (!_menuComponents.Contains(component))
            {
                throw new InvalidOperationException("Указанное блюдо не найдено в меню");
            }
            _menuComponents.Remove(component);
        }

        public virtual void Print()
        {
            Console.WriteLine(name);

            foreach (MenuComponent component in _menuComponents)
            {
                component.Print();
            }
        }
    }
}