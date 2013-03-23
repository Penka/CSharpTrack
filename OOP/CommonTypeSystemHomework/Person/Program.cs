using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 20);
            Person gosho = new Person("Gosho");

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}
