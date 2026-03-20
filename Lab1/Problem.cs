using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Problem
    {
        private int number_of_items { get; set; }
        private int seed { get; set; }
        public List<Item> items { get; set; } = new List<Item>();

        public Problem(int n, int s)
        {
            this.number_of_items = n;
            if (n <= 0)
            {
                throw new InvalidOperationException("nieprawidłowa ilosc przedmiotow");
            }
            this.seed = s;
            Random random = new Random(seed);
            for (int i = 0; i < number_of_items; i++)
            {
                items.Add(new Item(random.Next(1, 11), random.Next(1, 11), i));
                
            }
        }
        public string print_numbers(int n)
        {
            return $"Id {items[n].id}   Waga:{items[n].weight}   Wartosc:{items[n].value}";
        }
        public Result Solve(int capacity)
        {
            Result result = new Result();
            List<Item> przedmioty_sortowane = items.OrderByDescending(p => p.ratio).ToList();
            for (int i = 0; i < number_of_items; i++)
            {
                if (przedmioty_sortowane[i].weight + result.weight_sum <= capacity)
                {
                    result.weight_sum = result.weight_sum + przedmioty_sortowane[i].weight;
                    result.value_sum = result.value_sum + przedmioty_sortowane[i].value;
                    result.items_number.Add(przedmioty_sortowane[i].id);
                }

            }

            return result;

        }
    }
}
