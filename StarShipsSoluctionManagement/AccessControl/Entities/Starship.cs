namespace AccessControl.Entities
{
    public class Starship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Passengers { get; set; }
        public double CargoCapacity { get; set; }
        public string StarshipClass { get; set; }
    }
}
