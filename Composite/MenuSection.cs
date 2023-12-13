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

    }
}
