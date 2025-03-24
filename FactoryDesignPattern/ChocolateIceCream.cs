using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ChocolateIceCream : IIceCream
    {
        public string GetFlavor() => "Chocolate Ice Cream";
    }
}
