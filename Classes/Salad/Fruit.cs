using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Salad
{
    class Fruit : ISalad
    {
        public string Name => "Some FRUIT name";

        public decimal Price => 105;

        public int Weight => 110;

        public void DoSalad()
        {
            Console.WriteLine("DoSalad() for Fruit");
        }
    }
}
