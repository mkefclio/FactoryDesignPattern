﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class VanillaIceCream : IIceCream

    {
        public string GetFlavor() => "Vanilla Ice Cream";

    }
}
