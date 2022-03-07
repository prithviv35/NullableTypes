using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> n = null;

            // using the method
            // output will be 0 as default
            // value of null is 0
            Console.WriteLine(n.GetValueOrDefault());

            // defining Nullable type
            int? n1 = null;
            Console.WriteLine(n1.GetValueOrDefault());

            int? n2 = 47;
            Console.WriteLine(n2.GetValueOrDefault());

            int m = n2 ?? 50;

            Console.WriteLine("Value of m is: {0} ", m);

            int? m1 = n1 ?? 50;
            Console.WriteLine("Value of m1 is: {0}", m1);

            Console.ReadLine();
        }
    }
}
