using System;
using System.Collections.Generic;
using System.Text;

namespace Intro
{
    public class Quack : IQuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("Quack");
        }
    }
}
