using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfizm2
{
   public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog Sound");
        }
    }
}
