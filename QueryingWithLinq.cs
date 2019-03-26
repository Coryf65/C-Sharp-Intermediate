using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    class QueryingWithLinq
    {

        //C# features that support LINQ:

        //Anonymous Types
        //Extension Methods
        //Implicit Typing
        //Lambda Expressions
        //Object and Collection Initializers

        //"Writing Your First LINQ Query"

        public QueryingWithLinq()
        {
            
        }

        public void Run()
        {
            List<int> numbers = new List<int> { 2, 4, 8, 16, 32, 64 };
            List<int> numbersGreaterThanTen = new List<int>();
            List<int> numsGreaterThan10Linq = new List<int>();


            // Looping to find nums > 10
            foreach (int number in numbers)
            {
                if (number > 10)
                {
                    numbersGreaterThanTen.Add(number);
                }
            }

            //display results
            Console.WriteLine("using the for each loop...");

            // found a way to print into console
            //Console.WriteLine("Nums > 10: {0}", numbersGreaterThanTen);
            numbersGreaterThanTen.ForEach(i => Console.Write("{0}\t", i));
            //result: { 16, 32, 64}

            //numsGreaterThan10Linq = from numbers where numbers > 10 select number;

            // shorthand and displaying
            var linqResults = from n in numbers where n > 10 select n;

            // Now using LINQ
            Console.WriteLine("\n using LINQ...");
            //Console.WriteLine("Nums > 10: {0}", linqResults);
            Console.WriteLine(linqResults);


            // NOTE: LINQ uses deffered execution

            // PART 2
            Console.WriteLine("Starting part 2...");

            List<Bird> birds = new List<Bird> {
                new Bird { Name = "Cardinal", Color = "Red", Sightings = 3 },
                new Bird { Name = "Dove", Color = "White", Sightings = 2 },
                new Bird { Name = "Finch", Color = "yellow", Sightings = 10 }
            };

            // can add more using .Add Method
            birds.Add(new Bird { Name = "Robin", Color = "Red", Sightings = 2 });

            // or you could use the long version...
            Bird blueJay = new Bird();

            blueJay.Name = "Blue Jay";
            blueJay.Color = "Blue";
            blueJay.Sightings = 1;

            // now add the birb
            birds.Add(blueJay);

            foreach (Bird bird in birds)
            {
                Console.WriteLine("All birds: {0}", bird.Name);
            }

        }

        /// <summary>
        ///  Challenge 1 returning values
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<int> NumbersGreaterThanFive(List<int> list)
        {
            IEnumerable<int> lessThanFive;

            lessThanFive = from n in list where n > 5 select n;

            return lessThanFive;
        }
    }

    public class Bird
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Sightings { get; set; }
    }

}
