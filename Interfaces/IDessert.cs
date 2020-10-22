using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Interfaces
{
    //Dessert factory method
    interface IDessert : IDish
    {
        void DoDessert();
    }
}
