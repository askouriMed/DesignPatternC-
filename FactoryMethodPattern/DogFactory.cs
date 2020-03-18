namespace FactoryMethodPattern_Creational
{
    public class DogFactory:IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return  new Dog();
        }
    }
}
