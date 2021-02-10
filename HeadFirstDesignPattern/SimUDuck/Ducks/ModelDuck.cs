using HeadFirstDesignPattern.SimUDuck.Behavious;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SimUDuck.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("我是一只模型鸭");
        }
    }
}
