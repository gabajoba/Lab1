﻿using Lab1.Interfaces;
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
    class SupperMenu : IMenu
    {
        public IMain CreateMain()
        {
            return new Yogurt();
        }
        public ISalad CreateSalad()
        {
            return new Fruit();
        }

        public IDessert CreateDessert()
        {
            return new Cake();
        }

        public IDrink CreateDrink()
        {
            return new Tea();
        }
    }
}
