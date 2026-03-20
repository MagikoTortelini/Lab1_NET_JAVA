using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Item
    {
        public int weight { get; set; } = 0;
        public int value { get; set; } = 0;
        public int id { get; set; }
        public double ratio { get; set; }

        public Item(int weight, int value, int id)
        {
            this.weight = weight;
            this.value = value;
            this.id = id;
            this.ratio = value / weight;
        }
    }
}
