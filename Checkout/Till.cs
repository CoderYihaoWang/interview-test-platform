using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public class Till
    {
        private readonly Dictionary<char, Item> _items = new Dictionary<char, Item>
        {
            ['A'] = new ItemA(),
            ['B'] = new ItemB(),
            ['C'] = new ItemC(),
            ['D'] = new ItemD()
        };

        public double Total() 
        { 
            return _items.Select(i => i.Value.Total).Sum();
        }

        public void Scan(string items)
        {
           foreach(var item in items)
            {
                _items[char.ToUpper(item)].Add();
            }
        }
    }
}