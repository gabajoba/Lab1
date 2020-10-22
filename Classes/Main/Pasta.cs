using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Main
{
    class Pasta : IMain
    {
        public string Name => "Some PASTA name";

        public decimal Price => 200;

        public int Weight => 300;

        public void DoMain()
        {
            Console.WriteLine("DoMain() for Pasta");
        }
    }
}
