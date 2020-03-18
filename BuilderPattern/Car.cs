using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Car:IBuilder
    {
        private string brandName;

        private Product product;


        public Car(string brandName)
        {
            this.brandName = brandName;
            product = new Product();
        }

        public void StartUpOperations()
        {
            // Starting with brandname
            product.Add(string.Format("Car Model Name : {0}",brandName));
        }

        public void BuildBody()
        {
            product.Add("This is a body of a car");
        }

        public void InsertWheels()
        {
           product.Add("4 wheels are added");
        }

        public void AddHeadLigths()
        {
            product.Add("2 Headlights are added");
        }

        public void EndOperations()
        {
            // Nothing in this case
        }

        public Product GetVehicle()
        {
            return product;
        }
    }
}
