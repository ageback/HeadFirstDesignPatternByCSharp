using HeadFirstDesignPattern.SimUDuck.Ducks;
using HeadFirstDesignPattern.SimUDuck.Behavious;
using System;

namespace HeadFirstDesignPattern.SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            mallard.Display();
            Console.WriteLine();
            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

        }
    }
}
