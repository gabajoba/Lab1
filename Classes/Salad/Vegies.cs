using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Salad
{
    class Vegies : ISalad
    {
        public string Name => "Some VEGIES name";

        public decimal Price => 110;

        public int Weight => 120;

        public void DoSalad()
        {
            Console.WriteLine("DoSalad() for Vegies");
        }
    }
}
