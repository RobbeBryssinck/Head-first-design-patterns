using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public override string Description { get; }

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            Description = beverage.Description + ", Whip";
        }

        public override double Cost()
        {
            return 0.10 + beverage.Cost();
        }
    }
}


