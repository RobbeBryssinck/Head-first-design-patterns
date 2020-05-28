using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public override string Description { get; }

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            Description = beverage.Description + ", Mocha";
        }

        public override double Cost()
        {
            return 0.20 + beverage.Cost();
        }
    }
}
