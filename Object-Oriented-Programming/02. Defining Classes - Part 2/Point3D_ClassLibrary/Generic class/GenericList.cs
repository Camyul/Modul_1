

namespace Point3D_ClassLibrary.Generic_class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class GenericList<T>
    {
        private const int capacityDefault = 1;
        private T[] elements;

        public GenericList(int capacity = capacityDefault)
        {
            this.Count = 0;
            this.Capacity = capacity;
            this.elements = new T[Capacity];
        }
        public int Count { get; set; }
        public int Capacity { get; set; }
    }
}
