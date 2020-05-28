using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public override string Description { get; }

        public DarkRoast()
        {
            Description = "Dark roast";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
