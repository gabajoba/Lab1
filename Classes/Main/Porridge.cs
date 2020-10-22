using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Classes.Main
{
    class Porridge : IMain
    {
        public string Name => "Some PORRIDGE name";

        public decimal Price => 205;

        public int Weight => 310;

        public void DoMain()
        {
            Console.WriteLine("DoMain() for Porridge");
        }
    }
}
