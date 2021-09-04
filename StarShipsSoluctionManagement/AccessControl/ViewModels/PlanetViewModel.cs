using System.Linq;

namespace AccessControl.ViewModels
{
    public class PlanetViewModel
    {
        public string Name { get; set; }
        public string Rotation_Period { get; set; }
        public string Orbital_Period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Population { get; set; }
        public string Url { get; set; }

        public int Id
        {
            get
            {
                return int.Parse(Url?.Split('/').Where(urlPart => !string.IsNullOrEmpty(urlPart)).LastOrDefault());
            }
        }
    }
}
