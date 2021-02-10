using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SimUDuck.Behavious
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我利用火箭飞行！");
        }
    }
}
