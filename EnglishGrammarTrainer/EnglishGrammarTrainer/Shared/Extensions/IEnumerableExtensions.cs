using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammarTrainer.Shared.Extensions
{
    public static class IEnumerableExtensions
    {
        public static List<TResult> SelectList<TSource, TResult>(this IEnumerable<TSource> enumerable, Func<TSource, TResult> selector)
        {
            return enumerable.Select(selector).ToList();
        }

        public static TResult[] SelectArray<TSource, TResult>(this IEnumerable<TSource> enumerable, Func<TSource, TResult> selector)
        {
            return enumerable.Select(selector).ToArray();
        }
    }
}
