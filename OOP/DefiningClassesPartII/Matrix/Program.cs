using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { {1, 2}, {3, 4} };
            Matrix<int> a = new Matrix<int>(arr);
            Matrix<int> b = new Matrix<int>(arr);
            Matrix<int> sum = a + b;
            Matrix<int> sub = a - b;
            Matrix<int> mult = a * b;

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(sum.ToString());
            Console.WriteLine(sub.ToString());
            Console.WriteLine(mult.ToString());

            if (sum) 
            {
                Console.WriteLine("Non-zero");
            }

        }
    }
}
