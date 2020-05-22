using System;
using System.Collections.Generic;
using System.Text;

namespace Intro
{
    public class MuteQuack : IQuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
