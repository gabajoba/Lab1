using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Main
{
    class Yogurt : IMain
    {
        public string Name => "Some YOGURT name";

        public decimal Price => 210;

        public int Weight => 320;

        public void DoMain()
        {
            Console.WriteLine("DoMain() for Yogurt");
        }
    }
}
