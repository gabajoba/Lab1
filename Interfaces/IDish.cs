﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Interfaces
{
    interface IDish
    {
        string Name { get; }
        decimal Price { get; }
        int Weight { get; }
    }
}
