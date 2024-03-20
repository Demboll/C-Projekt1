using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{

    public class Backpack
    {
        public Backpack(int n, int seed, int capacity)
        {
            item_amount = n;
            C = capacity;

            Random rnd = new Random(seed);

            for(int i = 0; i < n; i++)
            {
                Items item = new Items(rnd.Next(10), rnd.Next(10));
                item_list.Add(item);
            }

        }

        public int C;
        public int item_amount;
        public List<Items> item_list;

        public void Solve()
        {
            var sortedItems = item_list.OrderBy(p => p.relation).ToList();
            int temp_C = this.C;
            for(int i = 0;i< sortedItems.Count;i++)
            {
                if (temp_C - sortedItems[i].weight  > 0)
                {
                    Console.WriteLine($"Item {i}: v:{sortedItems[i].value} w:{sortedItems[i].weight}");
                }
                else
                {
                    continue;
                }


                
            }

        }

    }
}
