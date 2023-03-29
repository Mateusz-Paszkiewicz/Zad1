using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Zad1GUI"), InternalsVisibleTo("UnitTestZad1")]

namespace Zad1
{
    public class Backpack
    {
        public List<Item> itemOrder;
        public List<Item> items;

        int _backpackSize;
        int _totalWeight;
        int _totalValue;
        int C;

        public Backpack(int number, int seed)
        {
            items = new List<Item>();
            Random rng = new Random(seed);

            _backpackSize = number;
            C = rng.Next(20, 50);

            for (int i = 0; i < _backpackSize; i++)
            {
                items.Add(new Item(rng.Next(1, 10), rng.Next(1, 10)));
            }
        }

        public Backpack(List<Item> itemList, int C) 
        {
            this.items = itemList;
            this.C = C;
            this.itemOrder = new List<Item>();
            _totalValue = 0;
            _totalWeight = 0;
            _backpackSize = 0;
        }

        public int getSize() { return this._backpackSize; }

        public List<Item> getItemOrder() { return this.itemOrder; }

        public string solveProblem()
        { 
            itemOrder = new List<Item>();
            int flag = 1;
            int actualWeight = 0;
            int actualValue = 0;
            int i = 0;
            string result = "";
            while (i < this.items.Count & flag == 1)
            {
                if (actualWeight + items[i].Weight() <= this.C)
                {
                    actualWeight += items[i].Weight();
                    actualValue += items[i].Value();
                    result += items.IndexOf(items[i]) + " ";
                    this.itemOrder.Add(items[i]);
                    i++;
                }
                else { flag = 0; }
                this._totalWeight = actualWeight;
                this._totalValue = actualValue;
            }
            result += Environment.NewLine + " Waga: " + this._totalWeight + Environment.NewLine + " Wartosc: " + this._totalValue;
            return result;
        }

        public override string ToString()
        {
            string str = "Backpack limit is: " + this.C + " " + Environment.NewLine;
            for (int i = 0; i < this.items.Count(); i++)
            {
                str += this.items[i].Value() + " " + this.items[i].Weight() + Environment.NewLine;
            }
            return str;
        }
    }
}
