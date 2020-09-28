using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GenericsMethodsAndDelegates
{
    public static class CollectionExtensions
    {
        public static IEnumerable<TOutput> AsEnumerableOf<T, TOutput>(this IMyCollection<T> collection)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));

            foreach (var item in collection)
            {
                TOutput result = (TOutput)converter.ConvertTo(item, typeof(TOutput));
                yield return result;
            }
        }
    }
}
