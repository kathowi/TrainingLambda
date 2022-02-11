using System.Linq;

namespace TrainingLambda
{
    /*
     * More examples: 
     * https://www.c-sharpcorner.com/UploadFile/0f68f2/using-lambda-expression-over-a-list-in-C-Sharp/
     * https://linqsamples.com/linq-to-objects
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Animal> animals = new List<Animal>();

            Animal animal1 = new Animal("Hela", 2, "dog");
            Animal animal2 = new Animal("Loki", 3, "cat");
            Animal animal3 = new Animal("Luna", 5, "cat");
            Animal animal4 = new Animal("Pipi", 2, "hamster");
            Animal animal5 = new Animal("Munia", 3, "dog");
            Animal animal6 = new Animal("Łapek", 4, "cat");
            Animal animal7 = new Animal("Spaky", 12, "dog");
            Animal animal8 = new Animal("Alk", 2, "mouse");
           
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
            animals.Add(animal8);

            Console.WriteLine("Display all cats");
            var result = animals.Where(x => x.Type == "cat").ToList(); 
            result.ForEach(x => x.PrintInfo());

            Console.WriteLine("\nDisplay animals younger than 4 years");
            animals.Where(x => x.Age < 4).ToList().ForEach(x=> x.PrintInfo());

            Console.WriteLine("\nMax age");
            Console.WriteLine(animals.Max(x => x.Age));

            Console.WriteLine("\nLast animal in list");
            animals.Last().PrintInfo();

            Console.WriteLine("Animal type from user input");
            string input = Console.ReadLine();
            var result1 = animals.Where(x => x.Type == input).ToList();
            result1.ForEach(x => x.PrintInfo());

            Console.WriteLine("\nFirst animal in list");
            animals.First().PrintInfo();

            Console.WriteLine("\nAverage age of dog");
            var dogs = animals.Where(x => x.Type == "dog");
            Console.WriteLine(dogs.Average(y => y.Age));

            Console.WriteLine("\nSort a-z by name");
            var sortedAz = animals.OrderBy(x => x.Name).ToList();
            foreach (var sorted in sortedAz)
                Console.WriteLine(sorted.Name);

            Console.WriteLine("\nDisplay all rodents");
            var rodents = animals.Where(x => x.Type == "mouse" || x.Type == "hamster").ToList();
            rodents.ForEach(x => Console.WriteLine(x.Name));

            // another solution
            //var hamsters = animals.Where(x => x.Type == "hamster").ToArray();
            //var mouses = animals.Where(x => x.Type == "mouses").ToArray();
            //var rodents = mouses.Concat(hamsters);
            //foreach (var rodent in rodents)
            //    Console.WriteLine(rodent.Name)
        }
    }
}