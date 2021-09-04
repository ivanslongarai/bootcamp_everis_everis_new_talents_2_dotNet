using System.Collections.Generic;

namespace AccessControl.Entities
{
    public class Pilot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthYear { get; set; }
        public int IdPlanet { get; set; }

        //Relationships
        public Planet Planet { get; set; }
        public List<Starship> Starships { get; set; }
    }
}