using System;

namespace Polymorfizm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.Sound();

            Dog dog = new Dog();
            dog.Sound();
        }
    }
}
