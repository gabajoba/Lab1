using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Interfaces
{
    //Drink factory method
    interface IDrink : IDish
    {
        void DoDrink();
    }
}
