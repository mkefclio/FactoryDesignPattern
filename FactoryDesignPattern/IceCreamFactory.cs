using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    // Factory

    public class IceCreamFactory
    {
        public IIceCream CreateIceCream(string flavor)
        {
            return flavor.ToLower() switch
            {
                "vanilla" => new VanillaIceCream(),
                "chocolate" => new ChocolateIceCream(),
                "strawberry" => new StrawberryIceCream(),
                _ => throw new ArgumentException("Invalid flavor")
            };

        }
    }
}
