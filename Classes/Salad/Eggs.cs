using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Salad
{
    class Eggs : ISalad
    {
        public string Name => "Some EGGS name";

        public decimal Price => 100;

        public int Weight => 100;

        public void DoSalad()
        {
            Console.WriteLine("DoSalad() for Eggs");
        }
    }
}
