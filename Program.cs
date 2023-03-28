using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe przedmiotow");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe ziarno");
            int seed = int.Parse(Console.ReadLine());
            Backpack backpack = new Backpack(n, seed);
            Console.WriteLine(backpack);
            Console.WriteLine(backpack.solveProblem());
            Console.ReadLine();
        }
    }
}
