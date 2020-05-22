using System;
using System.Collections.Generic;
using System.Text;

namespace Intro
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior { get; set; }
        public IQuackBehavior quackBehavior { get; set; }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.QuackSound();
        }
        
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
