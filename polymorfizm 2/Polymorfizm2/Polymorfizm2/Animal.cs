using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfizm2
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual void sound()
        {
            Console.WriteLine("Sound");
        }
    }
}
