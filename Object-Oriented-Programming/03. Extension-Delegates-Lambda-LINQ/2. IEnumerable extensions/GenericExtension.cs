

namespace IEnumerable_extensions
{
    using System.Collections.Generic;
    using System.Linq;
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
        public static T MultiplyElement<T>(this IEnumerable<T> collection)
        {
            T mult = (dynamic)1;
            foreach (var item in collection)
            {
                mult *= (dynamic)item;
            }

            return mult;
        }
           public static T MinElement<T>(this IEnumerable<T> collection)
        {
            return collection.Min<T>();
        }
        public static T MaxElement<T>(this IEnumerable<T> collection)
        {
            return collection.Max<T>();
        }
        public static T Average<T>(this IEnumerable<T> collection)
        {
            T avrg = default(T);
            foreach (var item in collection)
            {
                avrg += (dynamic)item; 
            }
            int length = collection.Count();
            avrg /= (dynamic)length;
            return avrg;
        }
    }
}
