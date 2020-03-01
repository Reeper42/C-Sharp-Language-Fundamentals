using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items
{
    public abstract class Item //made abstract so we cannot instantiate using Item = new ItemBase()
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
