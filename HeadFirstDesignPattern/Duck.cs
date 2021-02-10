using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern
{
    class Duck
    {
        protected IQuackBehavior quackBehavior;
        protected IFlyBehavior flyBehavior;

        public void performQuack() => quackBehavior.Quack();
    }
}
