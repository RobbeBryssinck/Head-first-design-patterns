using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public override string Description { get; }

        public HouseBlend()
        {
            Description = "House blend coffe";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
