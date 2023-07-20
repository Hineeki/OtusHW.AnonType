using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW.AnonType
{
    public class Planet
    {
        public Planet(string name, int number, int equator, Planet previousPlanet)
        {
            Name = name;
            Number = number;
            EquatorLength = equator;
            PreviousPlanet = previousPlanet;
        }
        public string Name { get; }
        public int Number { get; }
        public int EquatorLength { get; }
        public Planet PreviousPlanet { get; }
    }
}
