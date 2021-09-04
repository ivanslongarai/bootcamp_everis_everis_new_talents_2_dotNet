using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AccessControl.Entities;

namespace AccessControl.Dao
{
    public class PlanetDao : BaseDao
    {
        public async Task Insert(List<Planet> planets)
        {
            if (!planets.Any())
                return;

            var check = "if (not exists(select 1 from Planets where Id = {0}))\n";
            var insert = "insert Planets (Id, Name, Rotation_Period, Orbital_Period, Diameter, Climate, Population) values ({0}, '{1}', {2}, {3}, {4}, '{5}', {6});\n";
            var command = planets.Select(planet => string.Format(check, planet.Id) + string.Format(insert, planet.Id, planet.Name, planet.RotationPeriod, planet.OrbitalPeriod, planet.Diameter, planet.Climate, planet.Population));

            await Insert(string.Join('\n', command));
        }
    }
}
