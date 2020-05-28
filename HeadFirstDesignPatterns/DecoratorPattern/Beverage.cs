using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public abstract string Description { get; }

        public abstract double Cost();
    }
}
