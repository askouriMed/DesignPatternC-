using System;

namespace FactoryMethodPattern
{
    public abstract  class IAnimalFactory
    {
        public abstract IAnimal CreateAnimal();

        public IAnimal MakeAnimal()
        {
            Console.WriteLine("*** You cannot ignore the Parent Rules  ****");

            IAnimal animal = CreateAnimal();
            animal.Speak();
            animal.Action();

            return animal;
        }
    }
}
