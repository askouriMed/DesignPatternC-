using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public abstract class BasicCare
    {
        public string ModelName { get; set; }
        public int Price { get; set; }
        public static int SetPrice()
        {
            //int price = 0;
            //Random r= new Random();
            //int p = r.Next(200000, 500000);
            //price = p;
            //return price;
            return 1000;
        } 

        public abstract BasicCare Clone();
    }
}
