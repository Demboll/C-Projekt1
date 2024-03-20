using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    public class Items
    {
        public int value;
        public int weight;
        public int relation;

        public Items(int itemValue, int itemWeight) 
        {
            value = itemValue;
            weight = itemWeight;

            relation = value / weight;
        }
    }


}
