

namespace IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class IEnumerableExtension    //Task 2
    {
        public static T SumOfElements<T>(this IEnumerable<T> collection)
        {
            T sum = default(T);
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }
            return sum;
        }        
    }
}
