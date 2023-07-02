using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Homework_6.CatalogPlanet;

namespace Homework_6
{
    internal class CatalogPlanet
    {
        private readonly List<Planet> _catalogPlanets;
        private int _count = 0;
        public delegate void PlanetValidator(string name);

        public CatalogPlanet()
        {
            var venera = new Planet("Венера", 2, 38025, null);
            var earth = new Planet("Земля", 3, 40075, venera);
            var mars = new Planet("Марс", 4, 38025, earth);

            _catalogPlanets = new List<Planet>
            {
               venera, earth, mars
            };
        }

        public (int, int, string?) GetPlanet(string namePlanet)
        {
            var foundPlanet = (equatorLength: 0, number: 0, exception: "Не удалось найти планету.");
            _count++;
                if (_count == 3)
                {
                Console.WriteLine("Вы спрашиваете слишком часто.");
                    _count = 0;
                }
                foreach (Planet planet in _catalogPlanets)
                {
                    if (planet.Name == namePlanet)
                    {
                        foundPlanet = (planet.EquatorLength, planet.Number, "Планета найдена.");
                    }
                }

            return foundPlanet;
        }

        public (int, int, string?) GetPlanetTwo(string namePlanet, PlanetValidator planetValidator)
        {
            var foundPlanet = (equatorLength: 0, number: 0, exception: "Не удалось найти планету.");

            planetValidator(namePlanet);
            foreach (Planet planet in _catalogPlanets)
            {
                if (planet.Name == namePlanet)
                {
                    foundPlanet = (planet.EquatorLength, planet.Number, "Планета найдена.");
                }
            }

            return foundPlanet;
        }
    }
}
