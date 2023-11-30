using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    internal class Menu : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();

        public Menu(string name)
            : base(name)
        { }

        public override void Add(MenuComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Блюда не существует");
            }
            _menuComponents.Add(component);
        }

        public override void Remove(MenuComponent component)
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

        public override void Print()
        {
            Console.WriteLine(name);

            foreach (MenuComponent component in _menuComponents)
            {
                component.Print();
            }
        }
    }
}
