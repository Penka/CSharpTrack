using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumbersDivisibleBy7And3
{
    class NumbersDivisibleBy7And3
    {
        public static void PrintResult(IEnumerable<int> result)
        {
            foreach (int number in result)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 21, 7, 12, 14, 9, 42, 21 };

            var lambdaResult = numbers.Where(x => x % 7 == 0 && x % 3 == 0);
            var linqResult =
                from number in numbers
                where number % 7 == 0 && number % 3 == 0
                select number;
            Console.WriteLine("Using lambda");
            PrintResult(lambdaResult);
            Console.WriteLine();
            Console.WriteLine("Using LINQ");
            PrintResult(linqResult);
        }
    }
}
