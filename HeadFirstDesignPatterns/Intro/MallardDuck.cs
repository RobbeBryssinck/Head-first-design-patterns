using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Intro
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real mallard duck.");
        }
    }
}
