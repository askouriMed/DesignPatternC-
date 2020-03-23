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
