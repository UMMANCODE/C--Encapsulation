using System;

namespace ConsoleApp18 {
    internal class Program {
        static void Main(string[] args) {
            byte numberOfCities;
            do {
                Console.Write("Enter number of cities: ");
            } while(!byte.TryParse(Console.ReadLine(), out numberOfCities));

            ChinaCity[] chinaCities = new ChinaCity[numberOfCities];

            for (int i = 0; i < numberOfCities; i++) {
                chinaCities[i] = new ChinaCity();

                do {
                    Console.Write("Enter city name: ");
                    chinaCities[0].Name = Console.ReadLine().Trim();
                } while (chinaCities[0].Name == null);

                int population;
                do {
                    Console.Write("Enter city population: ");
                    if (int.TryParse(Console.ReadLine(), out population))
                        chinaCities[0].Population = population;
                } while (chinaCities[0].Population == 0);
            }
            CalculateAveragePopulation(chinaCities);
        }

        static void CalculateAveragePopulation(ChinaCity[] chinaCities) {
            double totalPopulation = 0;
            for (int i = 0; i < chinaCities.Length; i++) {
                totalPopulation += chinaCities[i].Population;
            }
            Console.WriteLine($"Average population: {totalPopulation / chinaCities.Length}");
        }
    }
}
