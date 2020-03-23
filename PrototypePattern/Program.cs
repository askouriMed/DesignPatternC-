using System;

namespace PrototypePattern
{
    /// <summary>
    /// GoF Definition
    /// Specify the kinds of objects to create using a prototypical instance, and create new
    /// objects by copying this prototype.
    /// </summary>
     

    public class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("*** Prototype Pattern  Demo *** \n");
            // Base or Original Copy
            BasicCare nano_Base= new Nano("Green Nano"){Price = 100000};


            BasicCare ford_Base= new Ford("Ford Yellow"){Price = 200000};

            BasicCare bc1;
            bc1 = nano_Base.Clone();
            bc1.Price = nano_Base.Price + BasicCare.SetPrice();

            Console.WriteLine("Car is: {0}, and it's price is RS. {1}",bc1.ModelName,bc1.Price);


            bc1 = ford_Base.Clone();
            bc1.Price = ford_Base.Price + BasicCare.SetPrice();

            Console.WriteLine("Car is: {0}, and it's price is RS. {1}", bc1.ModelName, bc1.Price);

        }
    }
}
