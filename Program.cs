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

            QueryingWithLinq queryingWithLinq = new QueryingWithLinq();

            queryingWithLinq.Run();

            // pausing to read input
            Console.ReadKey();

        }

        
    }
}
