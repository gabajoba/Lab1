using Lab1.Classes.Dessert;
using Lab1.Classes.Main;
using Lab1.Classes.Drink;
using Lab1.Classes.Salad;
using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.AbstractClasses
{
    class BreakfastMenu : IMenu
    {
        public IMain CreateMain()
        {
            return new Porridge();
        }
        public ISalad CreateSalad()
        {
            return new Eggs();
        }
        public IDessert CreateDessert()
        {
            return new Pancake();
        }
        public IDrink CreateDrink()
        {
            return new Coffee();
        }
    }
}
