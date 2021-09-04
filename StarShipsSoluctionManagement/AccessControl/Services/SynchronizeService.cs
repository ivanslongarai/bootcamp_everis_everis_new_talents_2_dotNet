using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using AccessControl.Dao;
using AccessControl.Entities;
using AccessControl.ViewModels;

namespace AccessControl.Services
{
    class SynchronizeService
    {
        private const string URL_PLANETS = "http://swapi.dev/api/planets/";
        private const string URL_STARSHIPS = "http://swapi.dev/api/starships/";
        private const string URL_PILOTS = "http://swapi.dev/api/people/";

        public Task Synchronize()
        {
            var tasks = new List<Task>();

            tasks.Add(SynchronizePlanets());
            tasks.Add(SynchronizeStarShips());

            Task.WhenAll(tasks);

           return SynchronizePilots();
        }

        private async Task SynchronizePlanets()
        {
            var httpClient = new HttpClient();
            var listPlanets = new List<PlanetViewModel>();
            ResultsFromApi<PlanetViewModel> resultsFromApi = null;

            do
            {
                resultsFromApi = await httpClient.GetFromJsonAsync<ResultsFromApi<PlanetViewModel>>(resultsFromApi?.Next ?? URL_PLANETS);
                listPlanets.AddRange(resultsFromApi.Results);
            } while (resultsFromApi.Next != null);

            var planets = listPlanets.Select(item => new Planet
            {
                Id = item.Id,
                Name = item.Name == "unknown" ? "Name was not informed" : item.Name,
                Climate = item.Climate == "unknown" ? "Climate was not informed" : item.Climate,
                Diameter = item.Diameter == "unknown" ? 0 : double.Parse(item.Diameter),
                OrbitalPeriod = item.Orbital_Period == "unknown" ? 0 : double.Parse(item.Orbital_Period),
                RotationPeriod = item.Rotation_Period == "unknown" ? 0 : double.Parse(item.Rotation_Period),
                Population = item.Population == "unknown" ? 0 : long.Parse(item.Population)
            }).ToList();

            using (var dao = new PlanetDao())
                await dao.Insert(planets);

        }

        private async Task SynchronizeStarShips()
        {
            var httpClient = new HttpClient();
            var listStarShips = new List<StarShipViewModel>();
            ResultsFromApi<StarShipViewModel> resultsFromApi = null;

            do
            {
                resultsFromApi = await httpClient.GetFromJsonAsync<ResultsFromApi<StarShipViewModel>>(resultsFromApi?.Next ?? URL_STARSHIPS);
                listStarShips.AddRange(resultsFromApi.Results);
            } while (resultsFromApi.Next != null);

            var starships = listStarShips.Select(item => new Starship
            {
                Id = item.Id,
                Name = item.Name == "unknown" ? "Name was not informed" : item.Name,
                CargoCapacity = item.Cargo_Capacity == "unknown" ? 0 : double.Parse(item.Cargo_Capacity),
                StarshipClass = item.Starship_Class == "unknown" ? "StarshipClass was not informed" : item.Starship_Class,
                Model = item.Model == "unknown" ? "Model was not informed" : item.Model,
                Passengers = (item.Passengers == "n/a" || item.Passengers == "unknown") ? 0 : (int)double.Parse(item.Passengers)
            }).ToList();

            using (var dao = new StarShipDao())
                await dao.Insert(starships);
        }

        private async Task SynchronizePilots()
        {
            var httpClient = new HttpClient();
            var listPilots = new List<PilotViewModel>();
            ResultsFromApi<PilotViewModel> resultsFromApi = null;

            do
            {
                resultsFromApi = await httpClient.GetFromJsonAsync<ResultsFromApi<PilotViewModel>>(resultsFromApi?.Next ?? URL_PILOTS);
                listPilots.AddRange(resultsFromApi.Results.Where(p => p.Starships.Any()).ToList());
            } while (resultsFromApi.Next != null);

            var pilots = listPilots.Select(item => new Pilot
            {
                Id = item.Id,
                Name = item.Name == "unknown" ? "Name was not informed" : item.Name,
                BirthYear = item.Birth_Year == "unknown" ? "BirthYear was not informed" : item.Birth_Year,
                IdPlanet = item.IdPlanet,
                Starships = item.IdStarships.Select(idStarship => new Starship
                {
                    Id = int.Parse(idStarship)
                }).ToList()
            }).ToList();

            using (var pilotDao = new PilotDao())
            {
                await pilotDao.Insert(pilots);
                await pilotDao.InsertPilotsStarships(pilots);
            }
        }

    }
}
