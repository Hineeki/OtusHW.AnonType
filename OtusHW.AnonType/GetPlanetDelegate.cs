using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW.AnonType
{
    public class PlanetCatalogWithDelegate
    {
        public PlanetCatalogWithDelegate() { }

        static Planet venus = new Planet("Venus", 2, 38025, null);
        static Planet earth = new Planet("Earth", 3, 40075, venus);
        static Planet mars = new Planet("Mars", 4, 21344, earth);

        List<Planet> _planets = new List<Planet>()
            {
            venus, earth, mars
            };
        public delegate string PlanetValidator(string planetName);
        public (int, int, string) GetWithDelegate(string inputValue, PlanetValidator validator)
        {
            var i = validator(inputValue);
            if (i == null)
            {
                foreach (var item in _planets)
                {
                    if (inputValue == item.Name)
                    {
                        return (item.Number, item.EquatorLength, item.Name);
                    }
                }
                return (0, 0, "Не удалось найти планету.");
            }
            else
            {
                return (0,0, i.ToString());
            }
        }

        MyCounter counter = new MyCounter();
        public string DelegateCounter(string value)
        {
            counter.Increment();

            if (counter.Value > 2)
            {
                counter.Reset();
                return ("Вы слишком часто спрашиваете.");
            }
            return null;
        }
    }
}
