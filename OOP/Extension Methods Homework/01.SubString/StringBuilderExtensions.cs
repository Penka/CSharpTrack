using System.Text;

namespace _01.SubString
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder SubString(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder(length);
            for (int i = index; i < (index + length); i++)
            {
                result.Append(sb[i]);
            }
            return result;
        }
    }
}