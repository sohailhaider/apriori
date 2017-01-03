using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprioriSelf
{
    class ItemsSet
    {
        public int ID { get; set; }
        public List<Item> Items { get; set; }

        public double Support { get; set; }

        public ItemsSet()
        {
            Items = new List<Item>();
        }
    }
}
