using System;

namespace FactoryMethodPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** FActory Pattern Demo ****\n");

            IAnimalFactory tigerFactory= new TigerFactory();
            IAnimal tiger = tigerFactory.MakeAnimal();


            IAnimalFactory dogFactory= new DogFactory();
            IAnimal dog = dogFactory.MakeAnimal();

            Console.ReadKey();

        }
    }
}
