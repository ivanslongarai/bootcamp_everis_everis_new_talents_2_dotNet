using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AccessControl.Entities;
using AccessControl.Extensions;

namespace AccessControl.Dao
{
    public class StarShipDao : BaseDao
    {
        public async Task Insert(List<Starship> starships)
        {
            if (!starships.Any())
                return;

            var check = "if (not exists(select 1 from Starships where Id = {0}))\n";
            var insert = "insert into Starships (Id, Name, Model, Passengers, Cargo_Capacity, Starship_Class) values ({0}, '{1}', '{2}', {3}, {4}, '{5}');\n";
            var commands = starships.Select(starship => string.Format(check, starship.Id) + string.Format(insert, starship.Id, starship.Name, starship.Model, starship.Passengers, starship.CargoCapacity, starship.CargoCapacity));

            await Insert(string.Join('\n', commands));
        }

        public async Task<List<Starship>> GetByNameLike(string name)
        {
            var starships = new List<Starship>();
            var command = $"select * from Starships where name like '%{name.Replace(' ', '%')}%'";

            await Select(command, sqlDataReader =>
            {
                while (sqlDataReader.Read())
                {
                    starships.Add(new Starship
                    {
                        Id = sqlDataReader.GetValueOrDefault<int>("Id"),
                        Name = sqlDataReader.GetValueOrDefault<string>("Name")
                    });
                }
            });

            return starships;
        }

        public async Task<Starship> GetById(int idStarship)
        {
            Starship nave = null;
            var command = @$"
                                select	t1.*
                                from	Starships t1
                                where	t1.Id = {idStarship}";

            await Select(command, sqlDataReader =>
            {
                while (sqlDataReader.Read())
                {
                    nave = new Starship
                    {
                        Id = sqlDataReader.GetValueOrDefault<int>("Id"),
                        Name = sqlDataReader.GetValueOrDefault<string>("Name"),
                        Model = sqlDataReader.GetValueOrDefault<string>("Model"),
                        Passengers = sqlDataReader.GetValueOrDefault<int>("Passengers"),
                        CargoCapacity = sqlDataReader.GetValueOrDefault<double>("Cargo_Capacity"),
                        StarshipClass = sqlDataReader.GetValueOrDefault<string>("Starship_Class")
                    };
                }
            });

            return nave;
        }

        public async Task<int?> GetCommander(int idStarship)
        {
            int? idPilot = null;

            var command = $"select IdPilot from TravelsLogs t1 where t1.IdStarship = {idStarship} and t1.ArriveDate is null";

            await Select(command, sqlDataReader =>
            {
                while (sqlDataReader.Read())
                {
                    idPilot = sqlDataReader.GetValueOrDefault<int?>("IdPilot");
                }
            });

            return idPilot;
        }
    }
}
