using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    class MallardDuck:Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public void Display()
        {
            Console.WriteLine("我是一只真正的绿头鸭");
        }
    }
}
