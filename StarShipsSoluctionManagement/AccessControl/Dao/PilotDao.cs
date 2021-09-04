using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccessControl.Extensions;
using AccessControl.Entities;

namespace AccessControl.Dao
{
    public class PilotDao : BaseDao
    {
        public async Task Insert(List<Pilot> pilots)
        {
            if (!pilots.Any())
                return;

            var check = "if (not exists(select 1 from Pilots where Id = {0}))\n";
            var insert = "insert Pilots (Id, Name, Birth_Year, IdPlanet) values({0}, '{1}', '{2}', {3});\n";
            var commands = pilots.Select(pilot => string.Format(check, pilot.Id) + string.Format(insert, pilot.Id, pilot.Name, pilot.BirthYear, pilot.IdPlanet));

            await Insert(string.Join('\n', commands));
        }

        public async Task RegisterTravelStart(int idPilot, int idStarship)
        {
            StringBuilder command = new StringBuilder();

            command.AppendLine($"if (not exists(select 1 from TravelsLogs where IdPilot = {idPilot} and ArriveDate is null))");
            command.AppendLine($"begin");
            command.AppendLine($"   insert TravelsLogs (IdStarship, IdPilot, DepartureDate) values({idStarship}, {idPilot}, GetDate());");
            command.AppendLine($"end");

            await Insert(string.Join('\n', command.ToString()));
        }

        public async Task RegisterTravelEnd(int idPilot, int idStarship)
        {
            StringBuilder command = new StringBuilder();
            command.AppendLine($"update TravelsLogs set ArriveDate = GetDate() where IdPilot = {idPilot} and IdStarship = {idStarship} and ArriveDate is null;");

            await Insert(string.Join('\n', command.ToString()));
        }

        public async Task InsertPilotsStarships(List<Pilot> pilots)
        {
            if (!pilots.Any())
                return;

            var check = "if (not exists(select 1 from PilotsStarships where IdPilot = {0} and IdStarship = {1}))\n";
            var insert = "insert PilotsStarships (IdPilot, IdStarship) values ({0}, {1});\n";
            var command = pilots.SelectMany(pilot => pilot.Starships.Select(starship => string.Format(check, pilot.Id, starship.Id) + string.Format(insert, pilot.Id, starship.Id)));

            await Insert(string.Join('\n', command));
        }

        public async Task<bool> IsPilotTraveling(int idPilot)
        {
            bool traveling = false;

            var command = $"select convert(bit, case when count(DepartureDate) <> count(ArriveDate) then 1 else 0 end) Traveling from TravelsLogs where IdPilot = {idPilot}";

            await Select(command, sqlDataReader =>
            {
                while (sqlDataReader.Read())
                {
                    traveling = sqlDataReader.GetValueOrDefault<bool>("Traveling");
                }
            });

            return traveling;
        }

        public async Task<Pilot> GetById(int idPilot)
        {
            Pilot pilot = null;
            var command = @$"
                                select  t1.Id,
                                        t1.Name,
                                        t1.Birth_Year,
                                        t2.Id PlanetId,
                                        t2.Name PlanetName,
                                        t2.Rotation_Period,
                                        t2.Orbital_Period,
                                        t2.Diameter,
                                        t2.Climate,
                                        t2.Population
                                from    Pilots t1
                                inner   join Planets t2
                                on      t1.IdPlanet = t2.Id
                                where   t1.Id = {idPilot}";

            await Select(command, sqlDataReader =>
            {
                while (sqlDataReader.Read())
                {
                    pilot = new Pilot
                    {
                        Id = sqlDataReader.GetValueOrDefault<int>("Id"),
                        Name = sqlDataReader.GetValueOrDefault<string>("Name"),
                        BirthYear = sqlDataReader.GetValueOrDefault<string>("Birth_Year"),
                        IdPlanet = sqlDataReader.GetValueOrDefault<int>("PlanetId"),
                        Planet= new Planet
                        {
                            Id = sqlDataReader.GetValueOrDefault<int>("PlanetId"),
                            Name = sqlDataReader.GetValueOrDefault<string>("PlanetName"),
                            RotationPeriod = sqlDataReader.GetValueOrDefault<double>("Rotation_Period"),
                            OrbitalPeriod = sqlDataReader.GetValueOrDefault<double>("Orbital_Period"),
                            Diameter = sqlDataReader.GetValueOrDefault<double>("Diameter"),
                            Climate = sqlDataReader.GetValueOrDefault<string>("Climate"),
                            Population = sqlDataReader.GetValueOrDefault<int>("Population")
                        }
                    };
                }
            });

            pilot.Starships = new List<Starship>(); 
            command = @$"
                                select  t2.*
                                from    PilotsStarships t1
                                inner   join Starships t2
                                on      t1.IdStarship = t2.Id
                                where   t1.FlagAuthorized = 1
                                and     t1.IdPilot = {idPilot}";

            await Select(command, sqlDataReader =>
            {
                while (sqlDataReader.Read())
                {
                    pilot.Starships.Add(new Starship
                    {
                        Id = sqlDataReader.GetValueOrDefault<int>("Id"),
                        Name = sqlDataReader.GetValueOrDefault<string>("Name"),
                        Model = sqlDataReader.GetValueOrDefault<string>("Model"),
                        Passengers = sqlDataReader.GetValueOrDefault<int>("Passengers"),
                        CargoCapacity = sqlDataReader.GetValueOrDefault<double>("Cargo_Capacity"),
                        StarshipClass = sqlDataReader.GetValueOrDefault<string>("Starship_Class")
                    });
                }
            });

            return pilot;
        }

        public async Task<List<Pilot>> GetByNameLike(string name)
        {
            var pilots = new List<Pilot>();
            var command = $"select * from Pilots where Name like '%{name.Replace(' ', '%')}%'";

            await Select(command, sqlDataReader =>
            {
                while (sqlDataReader.Read())
                {
                    pilots.Add(new Pilot
                    {
                        Id = sqlDataReader.GetValueOrDefault<int>("Id"),
                        Name = sqlDataReader.GetValueOrDefault<string>("Name")
                    });
                }
            });

            return pilots;
        }
    }
}