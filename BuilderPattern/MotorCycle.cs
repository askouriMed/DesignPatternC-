using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
   public class MotorCycle:IBuilder
   {
       private string brandName;
       private Product product;


       public MotorCycle(string brandName)
       {
           this.brandName = brandName;
           this.product = new Product();
       }
        public void StartUpOperations()
        {
            // Nothing in this case
        }

        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }

        public void InsertWheels()
        {
            product.Add("2 Wheels are added");
        } 

        public void AddHeadLigths()
        {
            product.Add("1 Headlights are added");
        }

        public void EndOperations()
        {
            // Finishing up with brandname
            product.Add(string.Format("Motorcycle Model name :{0}",brandName));
        }

        public Product GetVehicle()
        {
            return product;
        }
    }
}
