using System.Reflection.Metadata.Ecma335;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program1();
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