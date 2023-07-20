using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Diagnostics.Metrics;

namespace OtusHW.AnonType
{
    public class PlanetCatalog
    {
        public PlanetCatalog() { }

        MyCounter counter = new MyCounter();

        static Planet venus = new Planet("Venus", 2, 38025, null);
        static Planet earth = new Planet("Earth", 3, 40075,  venus);
        static Planet mars = new Planet("Mars", 4, 21344,  earth);

        List<Planet> _planets = new List<Planet>() 
        {
            venus, earth, mars
        };
        public (int, int, string) GetPlanet(string inputValue)
        {
            counter.Increment();
            
            if (counter.Value > 2)
            {
                counter.Reset();
                return (0, 0, "Вы слишком часто спрашиваете.");
            }
            else if (counter.Value <= 2) 
            {
                foreach (var item in _planets)
                {
                    if (inputValue == item.Name)
                    {
                        return (item.Number, item.EquatorLength, item.Name);
                    }
                }
            }
            
            return (0, 0, "Не удалось найти планету.");
        }
    }
}
