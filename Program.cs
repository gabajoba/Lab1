using Lab1.AbstractClasses;
using Lab1.Classes;
using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
               
            try
            {
                //breakfastmenu
                if (DateTime.Now.Hour >= 7 && DateTime.Now.Hour <= 11)
                {
                    Cafe cafe = new Cafe(new BreakfastMenu());

                    Console.WriteLine($"Good morning! It's {DateTime.Now.ToString("HH:mm")} o'clock, today's menu:\n");
                    Console.WriteLine(cafe.ToString());
                    Console.WriteLine("You can also try our lunch menu, come here from 12 to 15 hours");
                    //just for test
                    cafe.Main.DoMain();
                    cafe.Salad.DoSalad();
                    cafe.Dessert.DoDessert();
                    cafe.Drink.DoDrink();
                }
                //lunchmenu
                else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 14)
                {
                    Cafe cafe = new Cafe(new LunchMenu());

                    Console.WriteLine($"Good afternoon! It's {DateTime.Now.ToString("HH: mm")} o'clock, today's menu:\n");
                    Console.WriteLine(cafe.ToString());
                    Console.WriteLine("You can also try our supper menu, come here from 15 to 19 hours");
                    //just for test
                    cafe.Main.DoMain();
                    cafe.Salad.DoSalad();
                    cafe.Dessert.DoDessert();
                    cafe.Drink.DoDrink();
                }
                //suppermenu
                else if (DateTime.Now.Hour >= 15 && DateTime.Now.Hour <= 18)
                {
                    Cafe cafe = new Cafe(new SupperMenu());

                    Console.WriteLine($"Good evening! It's {DateTime.Now.ToString("HH: mm")} o'clock, today's menu:\n");       
                    Console.WriteLine(cafe.ToString());
                    Console.WriteLine("You can also try our breakfast menu, come here tommorow from 7 to 12 hours");
                    //just for test
                    cafe.Main.DoMain();
                    cafe.Salad.DoSalad();
                    cafe.Dessert.DoDessert();
                    cafe.Drink.DoDrink();
                } else
                {
                    Console.WriteLine("The Cafe is not working at the moment");
                }
            } catch(Exception e)
            {
                Console.WriteLine($"{e.ToString()}");
            }
            
        }
    }
}
