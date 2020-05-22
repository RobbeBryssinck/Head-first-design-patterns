using System;
using System.Collections.Generic;
using System.Text;

namespace Intro
{
    public class Squeak : IQuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("Squeak");
        }
    }
}
