using System;
using System.Collections.Generic;
using System.Text;

namespace Intro
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real model duck");
        }
    }
}
