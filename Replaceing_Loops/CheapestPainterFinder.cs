using System;
using System.Collections.Generic;
using System.Linq;

namespace Replaceing_Loops
{
    static class CheapestFinder
    {
        public static T MinValueFinder<T, TIn>(this IEnumerable<T> list, Func<T, TIn> func)
            where T : class
            where TIn : IComparable<TIn>
            =>
            list.
                 Aggregate(
                            (T)(null),
                            (a, b) => a != null && func(a).CompareTo(func(b)) < 0 ? a : b,
                            f => (T)(null)
                            );
    }
}
//list.
//     Select(obj => Tuple.Create(obj, func(obj))).
//     Aggregate((Tuple<T, TIn>)null,
//     (best, cur) => best == null || cur.Item2.CompareTo(best.Item2) < 0 ? cur : best).
//     Item1;