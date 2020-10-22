using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Drink
{
    class Tea : IDrink
    {
        public string Name => "Some TEA name";

        public decimal Price => 25;

        public int Weight => 220;

        public void DoDrink()
        {
            Console.WriteLine("DoDrink() for Tea");
        }
    }
}
