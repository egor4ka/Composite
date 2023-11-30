using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class MenuSection : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();

        public MenuSection(string name)
            : base(name)
        { }

        public override void Add(MenuComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Компонент не существует");
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
                throw new InvalidOperationException("Указанный компонент не найден в секции");
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
