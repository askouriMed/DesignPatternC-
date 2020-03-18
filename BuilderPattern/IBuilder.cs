using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadLigths();
        void EndOperations();
        Product GetVehicle();
    }
}
