using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class MenuItem : MenuComponent
    {
        public MenuItem(string name)
            : base(name)
        { }

        public override void Add(MenuComponent component)
        {
            throw new Exception("Блюдо нельзя добавить");
        }

        public override void Remove(MenuComponent component)
        {
            throw new Exception("Блюдо нельзя удалить");
        }
    }
}
