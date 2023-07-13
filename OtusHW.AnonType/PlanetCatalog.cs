using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Program
{
    class PlanetCatalog
    {
        public PlanetCatalog() { }

        static Planet venus = new Planet("Venus", 2, 38025,  null);
        static Planet earth = new Planet("Earth", 3, 40075,  venus);
        static Planet mars = new Planet("Mars", 4, 21344,  earth);

        public (int, int, string) TakePlanet(string planetName)
        {
            int planetNumber = 0;
            int planetEquator = 0;
            string space = null;
            string error = "Не удалось найти планету.";

            switch (planetName)
            {
                case "Venus":
                    planetNumber = venus.Number;
                    planetEquator = venus.EquatorLength;
                    return (planetNumber, planetEquator, space);
                case "Earth":
                    planetNumber = earth.Number;
                    planetEquator = earth.EquatorLength;
                    return (planetNumber, planetEquator, space);
                case "Mars":
                    planetNumber = mars.Number;
                    planetEquator = mars.EquatorLength;
                    return (planetNumber, planetEquator, space);
                default:
                    return(planetNumber, planetEquator, error);
            }
        }
    }
}
