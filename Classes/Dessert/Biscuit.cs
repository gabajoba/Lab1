using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Dessert
{
    class Biscuit : IDessert
    {
        public string Name => "Some BISCUIT name";

        public decimal Price => 100;

        public int Weight => 40;

        public void DoDessert()
        {
            Console.WriteLine("DoDessert() for Biscuit");
        }
    }
}
