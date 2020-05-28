using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public override string Description { get; }

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            Description = beverage.Description + ", Soy";
        }

        public override double Cost()
        {
            return 0.15 + beverage.Cost();
        }
    }
}

