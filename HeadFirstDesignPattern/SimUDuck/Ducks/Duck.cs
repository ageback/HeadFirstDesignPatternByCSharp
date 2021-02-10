using HeadFirstDesignPattern.SimUDuck.Behavious;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SimUDuck.Ducks
{
    public abstract class Duck
    {
        protected IQuackBehavior quackBehavior;
        protected IFlyBehavior flyBehavior;

        public Duck() { }

        public abstract void Display();

        public void PerformFly() => flyBehavior.Fly();

        public void PerformQuack() => quackBehavior.Quack();

        public void Swim() => Console.WriteLine("所有鸭子都能浮起来，即使是诱饵鸭！");

        public void SetFlyBehavior(IFlyBehavior fb) => flyBehavior = fb;
        public void SetQuackBehavior(IQuackBehavior qb) => quackBehavior = qb;
    }
}
