using System;
using System.Text;

namespace GenericListTest
{
    class GenericList<T> where T : IComparable<T>
    {
        private T[] array;
        private int lastElementIndex; //index of the position of the last element

        public int Length
        {
            get
            {
                return this.lastElementIndex + 1;
            }
        }

        public GenericList(int capacity)
        {
            array = new T[capacity];
            this.lastElementIndex = -1;
        }

        public T this[int index]
        {
            get
            {
                if (index > lastElementIndex || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.array[index];
            }
            set
            {
                if (index > lastElementIndex || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                this.array[index] = value;
            }
        }

        public void Add(T element)
        {
            InsertElementInternal(lastElementIndex + 1, element);
        }

        public void InsertAt(int index, T element)
        {
            if (index < 0 || index > lastElementIndex)
            {
                throw new IndexOutOfRangeException();
            }
            InsertElementInternal(index, element);
        }
  
        private void InsertElementInternal(int index, T element)
        {
            lastElementIndex++;
            if (lastElementIndex >= array.Length)
            {
                EnlargeList();
            }
            RearrangeAtAdd(index);
            array[index] = element;
        }
        
        private void RearrangeAtAdd(int index)
        {
            for (int i = lastElementIndex; i > index; i--)
            {
                array[i] = array[i - 1];
            }
        }

        public T GetElementAt(int index)
        {
            if (index < 0 || index > lastElementIndex)
            {
                throw new IndexOutOfRangeException();
            }
            return array[index];
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > lastElementIndex)
            {
                throw new IndexOutOfRangeException();
            }
            RearrangeAtRemove(index);
            lastElementIndex--;
        }

        private void RearrangeAtRemove(int index)
        {
            for (int i = index + 1; i < this.Length; i++)
            {
                array[i - 1] = array[i];
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i <= lastElementIndex; i++)
            {
                result.Append(array[i] + " ");
            }
            return result.ToString();
        }

        private void EnlargeList()
        {
            T[] newArray = new T[this.Length * 2];
            for (int i = 0; i < lastElementIndex; i++)
            {
                newArray[i] = array[i];
            }
            this.array = newArray;
        }

        public T Min()
        {
            if (lastElementIndex == -1)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            T minElement = array[0];
            for (int i = 1; i <= lastElementIndex; i++)
            {
                if (minElement.CompareTo(array[i]) > 0)
                {
                    minElement = array[i];
                }
            }
            return minElement;
        }

        public T Max()
        {
            if (lastElementIndex == -1)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            T maxElement = array[0];
            for (int i = 1; i <= lastElementIndex; i++)
            {
                if (maxElement.CompareTo(array[i]) < 0)
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }
    }
}
