using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_ExpressionTrees._08_CS_IEnumerableVsIQueryable
{
    public static class _08_CS_IEnumerableVsIQueryable
    {
        public static void Caller()
        {
            int[] ints = new[] { 1, 9, 2, 7, 4, 3, 6, 5 };

            //IEnumerable<int> result = ints.Where(i => i < 5);
            IEnumerable<int> result = Enumerable.Where(ints, i => i < 5); // ==== IEnumerable<int> result = ints.Where(i => i < 5);

            // var result2 = Queryable.Where(ints, i => i < 5); //Lambda jest konwertowana do obiektu, natomiast w przypadku Enumerable.Where do kodu

            //UWAGA: Porównanie !!!!
            //IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate);
            //IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate);
            //Func<TSource, int, bool> predicate vs. Expression<Func<TSource, int, bool>> predicate

            foreach (int i in result)
                    Console.WriteLine(i);
        }
    }
}
