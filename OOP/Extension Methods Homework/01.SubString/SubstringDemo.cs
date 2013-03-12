using System;
using System.Linq;
using System.Text;

namespace _01.SubString
{
    class SubstringDemo
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("substring task");
            StringBuilder substring = sb.SubString(3, 6);
            Console.WriteLine(substring.ToString());
        }
    }
}
