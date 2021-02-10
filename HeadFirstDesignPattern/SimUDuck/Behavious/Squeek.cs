using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SimUDuck.Behavious
{
    public class Squeek : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("吱吱");
        }
    }
}
