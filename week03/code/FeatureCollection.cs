public class FeatureCollection
{
    public Feature[] Features { get; set; }
    
    public class Feature
    {
        public Properties Properties { get; set;}
    }

    public class Properties
    {
        public double Magnitude { get; set;}
        public string Place {get; set;}
        public long Time {get; set;}
    }
}