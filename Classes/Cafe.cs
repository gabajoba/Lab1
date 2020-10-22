using Lab1.AbstractClasses;
using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1.Classes
{
    class Cafe
    {
        public IMain Main { get; }
        public ISalad Salad { get; }
        public IDessert Dessert { get; }
        public IDrink Drink { get; }
        public string Time
        {
            get
            {
                return DateTime.Now.ToString("HH:mm");
            }
        }
        public int Weight
        {
            get
            {
                return Main.Weight + Salad.Weight + Dessert.Weight + Drink.Weight;
            }
        }
        public decimal Price
        {
            get
            {
                return Main.Price + Salad.Price + Dessert.Price + Drink.Price;
            }
        }
        public override string ToString()
        {
            return $"{Main.Name} - {Main.Weight}g. - {Main.Price}rub.\n" +
                $"{Salad.Name} - {Salad.Weight}g. - {Salad.Price}rub.\n" +
                $"{Dessert.Name} - {Dessert.Weight}g. - {Dessert.Price}rub.\n" +
                $"{Drink.Name} - {Drink.Weight}g. - {Drink.Price}rub.\n";
        }
        public Cafe(IMenu menu)
        {
            Main = menu.CreateMain();
            Salad = menu.CreateSalad();
            Dessert = menu.CreateDessert();
            Drink = menu.CreateDrink();
        }
    }
}
