using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GenericList
{
    public class GenericList<T>
    {
        private T[] elements;
        private int count;
        private readonly int capacity;
        private int currentCapacity;

        public int Count 
        {
            get
            {
                return this.count;
            }
            set
            {
                if (value <= elements.Length)
                {
                    this.count = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.count = 0;
            this.capacity = capacity;
            this.currentCapacity = capacity;
        }

        public void Add(T item)
        {
            if (Count == elements.Length)
            {
                currentCapacity *= 2;
                T[] tempArr = new T[currentCapacity];
                for (int i = 0; i < elements.Length; i++)
                {
                    tempArr[i] = elements[i];
                }
                elements = tempArr;
                elements[Count] = item;
                Count++;
            }
            else
            {
                elements[Count] = item;
                Count++;
            }
        }

        public T this[int i]
        {
            get
            {
                if (i >= Count || i < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return elements[i];
            }
            set
            {
                if (i >= Count || i < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                elements[i] = value;
            }
        }

        public void RemoveAt(int index)
        {
            if (index > Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == Count)
            {
                elements[index] = default(T);
                Count--;
            }
            else
            {
                for (int i = index; i < Count - 1; i++)
                {
                    elements[i] = elements[i + 1];
                }
                Count--;
            }
        }

        public void InsertAt(int index, T item)
        {
            if (index > Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == Count)
            {
                Add(item);
            }
            else
            {
                if (Count == currentCapacity)
                {
                    Add(default(T));
                    Count--;
                }
                for (int i = Count; i >= index; i--)
                {
                    elements[i + 1] = elements[i];
                }
                elements[index] = item;
                Count++;
            }
        }

        public void Clear()
        {
            elements = new T[capacity];
            Count = 0;
        }

        public bool Contains(T item)
        {
            bool contains = false;
            for (int i = 0; i < Count; i++)
            {
                if (elements[i].Equals(item))
                {
                    contains = true;
                }
            }
            return contains;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Count == 0)
            {
                sb.Append("Empty!");
            }
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    sb.Append(elements[i] + " ");
                }
            }
            return sb.ToString();
        }

        public T Min()
        {
            T[] tempArr = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                tempArr[i] = elements[i];
            }
            return tempArr.Min<T>();
        }

        public T Max()
        {
            return elements.Max<T>();
        }
    }
}
