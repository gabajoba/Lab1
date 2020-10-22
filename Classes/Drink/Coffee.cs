using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Drink
{
    class Coffee : IDrink
    {
        public string Name => "Some COFFEE name";

        public decimal Price => 15;

        public int Weight => 200;

        public void DoDrink()
        {
            Console.WriteLine("DoDrink() for Coffee");
        }
    }
}
