using System;

namespace FactoryMethodPattern
{
    public class Tiger:IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Tiger prefer Hunting...\n");
        }

        public void Speak()
        {
            Console.WriteLine("Tiger Says Hummm...\n");
        }
    }
}
