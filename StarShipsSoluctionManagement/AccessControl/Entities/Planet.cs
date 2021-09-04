namespace AccessControl.Entities
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double RotationPeriod { get; set; }
        public double OrbitalPeriod { get; set; }
        public double Diameter { get; set; }
        public string Climate { get; set; }
        public long Population { get; set; }
    }
}
