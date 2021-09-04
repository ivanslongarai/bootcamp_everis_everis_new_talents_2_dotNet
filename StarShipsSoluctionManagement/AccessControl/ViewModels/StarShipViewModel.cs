using System.Linq;


namespace AccessControl.ViewModels
{
    public class StarShipViewModel
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Passengers { get; set; }
        public string Cargo_Capacity { get; set; }
        public string Starship_Class { get; set; }
        public string Url { get; set; }

        public int Id
        {
            get
            {
                return int.Parse(Url?.Split('/').Where(uPart => !string.IsNullOrEmpty(uPart)).LastOrDefault());
            }
        }
    }
}
