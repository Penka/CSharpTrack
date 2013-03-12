using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GroupFunctions
{
    public static class IEnumerableExtensions
    {
        public static dynamic Sum<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            if (collection.Count() == 0)
            {
                throw new ArgumentException();
            }
            dynamic sum = default(T);
            foreach (T element in collection)
            {
                sum += element;
            }
            return sum;
        }

        public static dynamic Product<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            if (collection.Count() == 0)
            {
                throw new ArgumentException();
            }
            dynamic product = 1;
            foreach (T element in collection)
            {
                product *= element;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            if (collection.Count() == 0)
            {
                throw new ArgumentException();
            }
            T min = collection.First();
            foreach (T element in collection)
            {
                if (min.CompareTo(element) > 0)
                {
                    min = element;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            if (collection.Count() == 0)
            {
                throw new ArgumentException();
            }
            T max = collection.First();
            foreach (T element in collection)
            {
                if (max.CompareTo(element) < 0)
                {
                    max = element;
                }
            }
            return max;
        }

        public static dynamic Average<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            if (collection.Count() == 0)
            {
                throw new ArgumentException();
            }
            dynamic sum = collection.Sum();
            dynamic average = sum / (collection.Count() * 1.0);
            return average;
        }
    }
}