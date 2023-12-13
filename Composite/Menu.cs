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

      
    }
}
