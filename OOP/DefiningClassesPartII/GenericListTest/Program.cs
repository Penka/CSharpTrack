using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> myList = new GenericList<int>(3);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(100);
            myList.Add(6);
            myList.InsertAt(2, 10);
            myList.Add(9);
            Console.WriteLine(myList.ToString());
            myList.RemoveAt(2);
            Console.WriteLine(myList.ToString());
            Console.WriteLine(myList.Max());
            Console.WriteLine(myList.Min());
            Console.WriteLine(myList[2]);
            Console.WriteLine(myList.GetElementAt(2));
        }
    }
}
