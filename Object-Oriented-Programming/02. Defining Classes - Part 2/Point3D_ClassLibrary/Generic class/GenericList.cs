

namespace Point3D_ClassLibrary.Generic_class
{
    using System;
    using System.Text;
    public class GenericList<T>
    {
        
        private const int capacityDefault = 1;
        private T[] elements;  

        public GenericList(int capacity = capacityDefault) // Constructor
        {
            this.Count = 0;
            this.Capacity = capacity;
            this.elements = new T[Capacity];
        }

        public int Count { get; private set; }  // Property
        public int Capacity { get; private set; }

        public T this[int index]                // Indexer
        {
            get
            {
                CheckIndex(index);
                return this.elements[index];
            }
            set { this.elements[index] = value; }
        }

        

        public void AddElement(T element)       //Metod
        {
            this.Count++;
            ResizeArr(this.Count);
            this.elements[this.Count - 1] = element;
        }
        public void RemoveAt(int index)     //Metod
        {
            CheckIndex(index);
            this.Count--;
            Array.Copy(this.elements, index + 1, this.elements, index, this.Count - index);
            elements[Count] = default(T);
        }
        public void InsertAt(T newElement, int index)//Metod
        {
            CheckIndex(index);
            this.Count++;
            ResizeArr(this.Count);
            Array.Copy(this.elements, index, this.elements, index + 1, this.Count - index - 1);
            elements[index] = newElement;
        }
        public override string ToString()   //Metod
        {
            StringBuilder genericToString = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                genericToString.Append(elements[i]);
                if (i != this.Count - 1)
                {
                    genericToString.Append(" ");
                }
            }
            return genericToString.ToString();
        }
        private void ResizeArr(int count)       //Metod
        {
            if (count > this.Capacity)
            {
                this.Capacity *= 2;
                Array.Resize(ref elements, this.Capacity);

            }

        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Index is bigger from Count or negativ");
            }
        }
    }
}
