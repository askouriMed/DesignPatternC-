using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Builder Pattern Demo***");
            Director director= new Director();

            IBuilder car=new Car("Mercedes");
            IBuilder motorCycle=new MotorCycle("Honda");

            // Making Car
            director.Construct(car);
            Product p1 = car.GetVehicle();
            p1.Show(); 
            
            // Making Car
            director.Construct(motorCycle);
            Product p2 = motorCycle.GetVehicle();
            p2.Show();

        }
    }
}
