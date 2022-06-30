using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfizm2
{
   public class Bird : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bird Sound");
        }
    }
}
