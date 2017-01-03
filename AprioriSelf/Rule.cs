using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprioriSelf
{
    class Rule
    {
        public List<Item> Driver { get; set; }
        public List<Item> Indicates { get; set; }
        public double confidence { get; set; }

        public Rule()
        {
            Driver = new List<Item>();
            Indicates = new List<Item>();
        }
    }
}
