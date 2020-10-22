using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Interfaces
{
    interface IMenu
    { 
        IMain CreateMain();
        ISalad CreateSalad();
        IDessert CreateDessert();
        IDrink CreateDrink();
        
       
        
    }
}
