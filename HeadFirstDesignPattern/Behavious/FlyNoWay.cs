using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SimUDuck.Behavious
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我不会飞……");
        }
    }
}
