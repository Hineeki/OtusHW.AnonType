using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace OtusHW.AnonType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Anon
            var ven1 = new { Name = "Venus", Number = 2, EquatorLength = 38025, PreviousPlanet = (object)null };
            var earth = new { Name = "Earth", Number = 3, EquatorLength = 40075, PreviousPlanet = ven1 };
            var mars = new { Name = "Mars", Number = 4, EquatorLength = 21344, PreviousPlanet = earth };
            var ven2 = new { Name = "Venus", Number = 2, EquatorLength = 38025, PreviousPlanet = (object)null };

            Console.WriteLine(
                $"Название: {ven1.Name}\tПорядковый номер от Солнца: {ven1.Number}.\tДлина экватора: {ven1.EquatorLength}." +
                $"\nПредыдущая планета: {ven1.PreviousPlanet}. Эквивалент Венере: {ven1.Equals(ven1)}\n" +
                $"Название: {earth.Name}\tПорядковый номер от Солнца: {earth.Number}.\tДлина экватора: {earth.EquatorLength}." +
                $"\nПредыдущая планета: {earth.PreviousPlanet}. Эквивалент Венере: {ven1.Equals(earth)}\n" +
                $"Название: {mars.Name}\tПорядковый номер от Солнца: {mars.Number}.\tДлина экватора: {mars.EquatorLength}." +
                $"\nПредыдущая планета: {mars.PreviousPlanet}. Эквивалент Венере: {ven1.Equals(mars)}\n" +
                $"Название: {ven2.Name}\tПорядковый номер от Солнца: {ven2.Number}.\tДлина экватора: {ven2.EquatorLength}." +
                $"\nПредыдущая планета: {ven2.PreviousPlanet}. Эквивалент Венере: {ven1.Equals(ven2)}\n");
            #endregion
            #region Кортежи
            PlanetCatalog catalog = new PlanetCatalog();

            Console.WriteLine(catalog.GetPlanet("Earth"));
            Console.WriteLine(catalog.GetPlanet("Lemonia"));
            Console.WriteLine(catalog.GetPlanet("Mars"));
            Console.WriteLine();
            #endregion
            #region Лямбда
            PlanetCatalogWithDelegate asd = new();
            MyCounter counter = new MyCounter();
            Console.WriteLine(asd.GetWithDelegate("Earth", asd.DelegateCounter));
            Console.WriteLine(asd.GetWithDelegate("Lemonia", asd.DelegateCounter));
            Console.WriteLine(asd.GetWithDelegate("Mars", asd.DelegateCounter));
            Console.WriteLine();

            Console.WriteLine(asd.GetWithDelegate("Earth", s => {
                counter.Increment();

                if (counter.Value > 2)
                {
                    counter.Reset();
                    return ("Вы слишком часто спрашиваете.");
                }
                return null;
            }));
            Console.WriteLine(asd.GetWithDelegate("Lemonia", s => {
                counter.Increment();

                if (counter.Value > 2)
                {
                    counter.Reset();
                    return ("Вы слишком часто спрашиваете.");
                }
                return null;
            }));
            Console.WriteLine(asd.GetWithDelegate("Mars", s => {
                counter.Increment();

                if (counter.Value > 2)
                {
                    counter.Reset();
                    return ("Вы слишком часто спрашиваете.");
                }
                return null;
            }));
            #endregion
        }
    }
}