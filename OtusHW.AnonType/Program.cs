using Program;

namespace OtusHW.AnonType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ven1 = new { Name = "Venus", Number = 2, EquatorLength = 38025, PreviousPlanet = (object) null };
            var earth = new { Name = "Earth", Number = 3, EquatorLength = 40075, PreviousPlanet = ven1 };
            var mars = new { Name = "Mars", Number = 4, EquatorLength = 21344, PreviousPlanet = earth };
            var ven2 = new { Name = "Venus", Number = 2, EquatorLength = 38025, PreviousPlanet = (object)null };

            Console.WriteLine(
                $"Название: {ven1.Name}\tПорядковый номер от Солнца: {ven1.Number}.\tДлина экватора: {ven1.EquatorLength}.\nПредыдущая планета: {ven1.PreviousPlanet}. {ven1.Equals(ven1)}\n" +
                $"Название: {earth.Name}\tПорядковый номер от Солнца: {earth.Number}.\tДлина экватора: {earth.EquatorLength}.\nПредыдущая планета: {earth.PreviousPlanet}. {ven1.Equals(earth)}\n" +
                $"Название: {mars.Name}\tПорядковый номер от Солнца: {mars.Number}.\tДлина экватора: {mars.EquatorLength}.\nПредыдущая планета: {mars.PreviousPlanet}. {ven1.Equals(mars)}\n" +
                $"Название: {ven2.Name}\tПорядковый номер от Солнца: {ven2.Number}.\tДлина экватора: {ven2.EquatorLength}.\nПредыдущая планета: {ven2.PreviousPlanet}. {ven1.Equals(ven2)}\n");

            PlanetCatalog catalog = new PlanetCatalog();
            Console.WriteLine(catalog.TakePlanet("asd"));
            Console.WriteLine(catalog.TakePlanet("Mars"));

        }
        //List<Planet> planetCatalog = new List<Planet>(3)
        //{
        //    new Planet("Venus", 2, 38025, ),
        //    new Planet("Earth", 3, 40075, "Venus"),
        //    new Planet("Mars", 4, 21344, "Earth")
        //};
    }
}