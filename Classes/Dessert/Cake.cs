using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Dessert
{
    class Cake : IDessert
    {
        public string Name => "Some CAKE name";

        public decimal Price => 105;

        public int Weight => 50;

        public void DoDessert()
        {
            Console.WriteLine("DoDessert() for Сake");
        }
    }
}
