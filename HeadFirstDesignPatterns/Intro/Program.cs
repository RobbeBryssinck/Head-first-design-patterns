using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.flyBehavior = new FlyRocketPowered();
            model.PerformFly();
        }
    }
}
