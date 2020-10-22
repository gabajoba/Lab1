using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Drink
{
    class Compote : IDrink
    {
        public string Name => "Some COMPOTE name";

        public decimal Price => 20;

        public int Weight => 210;

        public void DoDrink()
        {
            Console.WriteLine("DoDrink() for Compote");
        }
    }
}
