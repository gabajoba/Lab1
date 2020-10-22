using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Dessert
{
    class Pancake : IDessert
    {
        public string Name => "Some PANCAKE name";

        public decimal Price => 110;

        public int Weight => 60;

        public void DoDessert()
        {
            Console.WriteLine("DoDessert() for Pancake");
        }
    }
}
