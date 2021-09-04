using System.Collections.Generic;
using System.Linq;

namespace AccessControl.ViewModels
{
    public class PilotViewModel
    {
        private List<string> _idsStarships;

        public string Name { get; set; }
        public string Birth_Year { get; set; }
        public string Homeworld { get; set; }
        public IReadOnlyList<string> Starships { get; set; }
        public string Url { get; set; }

        public int IdPlanet
        {
            get
            {
                return int.Parse(Homeworld?.Split('/').Where(uPart => !string.IsNullOrEmpty(uPart)).LastOrDefault());
            }
        }

        public IReadOnlyList<string> IdStarships
        {
            get
            {
                if (_idsStarships == null)
                    _idsStarships = Starships.Select(starship => starship?.Split('/').Where(uPart => !string.IsNullOrEmpty(uPart)).LastOrDefault()).ToList();

                return _idsStarships;
            }
        }

        public int Id
        {
            get
            {
                return int.Parse(Url?.Split('/').Where(uPart => !string.IsNullOrEmpty(uPart)).LastOrDefault());
            }
        }
    }
}