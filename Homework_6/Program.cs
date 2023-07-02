using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;


            Program1();
            Console.WriteLine("_____________________________");

            CatalogPlanet planet = new CatalogPlanet();
            var (equatorLength, number, exception) = planet.GetPlanet("Земля");
            Console.WriteLine(equatorLength + " " + number + " " + exception);
            var (equatorLength1, number1, exception1) = planet.GetPlanet("Лимония");
            Console.WriteLine(equatorLength1 + " " + number1 + " " + exception1);
            var (equatorLength2, number2, exception2) = planet.GetPlanet("Марс");
            Console.WriteLine(equatorLength2 + " " + number2 + " " + exception2);

            Console.WriteLine("_____________________________");

            var (equatorLength3, number3, exception3) = planet.GetPlanetTwo("Земля", name =>
            {
                count++;
                if (count == 3)
                {
                    Console.WriteLine("Вы спрашиваете слишком часто.");
                }
            });
            Console.WriteLine(equatorLength3 + " " + number3 + " " + exception3);
            var (equatorLength4, number4, exception4) = planet.GetPlanetTwo("Лимония", name =>
            {
                count++;
                if (count == 3)
                {
                    Console.WriteLine("Вы спрашиваете слишком часто.");
                }
            });
            Console.WriteLine(equatorLength4 + " " + number4 + " " + exception4);
            var (equatorLength5, number5, exception5) = planet.GetPlanetTwo("Марс", name =>
            {
                count++;
                if (count == 3)
                {
                    Console.WriteLine("Вы спрашиваете слишком часто.");
                }
            });
            Console.WriteLine(equatorLength5 + " " + number5 + " " + exception5);

        }


        public static void Program1()
        {
            var venera = new { Name = "Венера", Number = 2, EquatorLength = 38025, LastPlanet = null as string};
            var earth = new { Name = "Земля", Number = 3, EquatorLength = 40075, LastPlanet = venera.Name};
            var mars = new { Name = "Марс", Number = 4, EquatorLength = 21344, LastPlanet = earth.Name };
            var venera1 = new { Name = "Венера", Number = 2, EquatorLength = 38025, LastPlanet = mars.Name };

            Console.WriteLine("Имя - " + venera.Name + ", Порядковый номер планеты = " + venera.Number + ", Длина экватора = " + venera.EquatorLength + ", Ссылка на предыдущую планету " + venera.LastPlanet);
            Console.WriteLine("Планета " + venera.Name + " эквивалента Венере = " + venera.Equals(venera));
            Console.WriteLine("\n");

            Console.WriteLine("Имя - " + earth.Name + ", Порядковый номер планеты = " + earth.Number + ", Длина экватора = " + earth.EquatorLength + ", Ссылка на предыдущую планету " + earth.LastPlanet);
            Console.WriteLine("Планета " + earth.Name + " эквивалента Венере = " + earth.Equals(venera));
            Console.WriteLine("\n");

            Console.WriteLine("Имя - " + mars.Name + ", Порядковый номер планеты = " + mars.Number + ", Длина экватора = " + mars.EquatorLength + ", Ссылка на предыдущую планету " + mars.LastPlanet);
            Console.WriteLine("Планета " + mars.Name + " эквивалента Венере = " + mars.Equals(venera));
            Console.WriteLine("\n");

            Console.WriteLine("Имя - " + venera1.Name + ", Порядковый номер планеты = " + venera1.Number + ", Длина экватора = " + venera1.EquatorLength + ", Ссылка на предыдущую планету " + venera1.LastPlanet);
            Console.WriteLine("Планета " + venera1.Name + " эквивалента Венере = " + venera1.Equals(venera));
        }
    }
}