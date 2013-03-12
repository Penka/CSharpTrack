using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GroupFunctions
{
    class GroupFunctions
    {

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            int sum = numbers.Sum();
            Console.WriteLine("The sum is {0}", sum);
            int product = numbers.Product();
            Console.WriteLine("The product is {0}", product);
            int min = numbers.Min();
            Console.WriteLine("The minimal element is {0}", min);
            int max = numbers.Max();
            Console.WriteLine("The maximal element is {0}", max);
            double average = numbers.Average();
            Console.WriteLine("The average is {0}", average);
        }
    }
}
