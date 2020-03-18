using System;

namespace FactoryMethodPattern_Creational
{
    public class Dog:IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...\n");
        }

        public void Speak()
        {
            Console.WriteLine("Dog Says Bow Bow...\n");

        }
    }
}
