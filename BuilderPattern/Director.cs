using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
   public class Director
   {
         IBuilder builder;

        // A Series of steps-in real life, stpes are complex.
        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadLigths();
            builder.EndOperations();
        }
   }
}
