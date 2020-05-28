using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Decaf : Beverage
    {
        public override string Description { get; }

        public Decaf()
        {
            Description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
