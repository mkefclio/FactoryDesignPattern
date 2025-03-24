﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class StrawberryIceCream : IIceCream
    {
        public string GetFlavor() => "Strawberry Ice Cream";
    }
}
