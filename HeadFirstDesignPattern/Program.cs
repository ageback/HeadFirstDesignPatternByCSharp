using HeadFirstDesignPattern.SimUDuck.Ducks;
using System;

namespace HeadFirstDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            mallard.Display();
        }
    }
}
