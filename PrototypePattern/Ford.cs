namespace PrototypePattern
{
    public class Ford:BasicCare
    {
        public Ford(string m)
        {
            ModelName = m;
        } 


        public override BasicCare Clone()
        {
            return (Ford)MemberwiseClone();
        }

    }
}
