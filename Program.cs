using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {

            //C# features that support LINQ:

            //Anonymous Types
            //Extension Methods
            //Implicit Typing
            //Lambda Expressions
            //Object and Collection Initializers

            #region "Writing Your First LINQ Query"


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
            Console.WriteLine("Nums > 10: " + numbersGreaterThanTen);
            //result: { 16, 32, 64}

            //numsGreaterThan10Linq = from numbers where numbers > 10 select number;

            // shorthand and displaying
            var linqResults = from n in numbers where n > 10 select n;

            // Now using LINQ
            Console.WriteLine("using LINQ...");
            Console.WriteLine("Nums > 10: " + linqResults);

            // NOTE: LINQ uses deffered execution

            #endregion


        }
    }
}
