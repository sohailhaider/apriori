using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprioriSelf
{
    class Transaction
    {
        public int ID { get; set; }
        public List<Item> Items { get; set; }

        public Transaction()
        {
            Items = new List<Item>();
        }

        public string print()
        {
            String returnValue = "";
            foreach(Item i in Items)
            {
                returnValue += " " +i.ID;
            }

            return returnValue;
        }
    }
}
