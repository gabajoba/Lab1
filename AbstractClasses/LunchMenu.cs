using Lab1.Interfaces;
using Lab1.Classes.Dessert;
using Lab1.Classes.Main;
using Lab1.Classes.Drink;
using Lab1.Classes.Salad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.AbstractClasses
{
    class LunchMenu : IMenu
    {   
        public IMain CreateMain()
        {
            return new Pasta();
        }
        public ISalad CreateSalad()
        {
            return new Vegies();
        }

        public IDessert CreateDessert()
        {
            return new Biscuit();
        }

        public IDrink CreateDrink()
        {
            return new Compote();
        }      
    }
}
