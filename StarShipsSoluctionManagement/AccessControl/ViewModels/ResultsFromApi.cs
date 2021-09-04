using System.Collections.Generic;


namespace AccessControl.ViewModels
{
    public class ResultsFromApi<ViewModel>
    {
        public string Next { get; set; }
        public IReadOnlyList<ViewModel> Results { get; set; }
    }
}