using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Result
    {
        public List<int> items_number { get; set; } = new List<int>();
        public int value_sum { get; set; } = 0;
        public int weight_sum { get; set; } = 0;

        public override string ToString()
        {
            return $"Przedmioty: {string.Join(" ", items_number)}\r\nWartosc: {value_sum}\r\nWaga: {weight_sum}";
        }
    }
}
