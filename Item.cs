using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Item
    {
        int value, weight;

        public Item(int _value, int _weight)
        {
            value = _value;
            weight = _weight;
        }

        public int Weight() { return this.weight; }
        public int Value() { return this.value; }

        public static bool operator== (Item rhs, Item lhs)
        {
            return rhs.Weight()==lhs.Weight() && rhs.Value()==lhs.Value();
        }

        public static bool operator !=(Item rhs, Item lhs)
        {
            return rhs.Weight() != lhs.Weight() || rhs.Value() != lhs.Value();
        }

    }
}
