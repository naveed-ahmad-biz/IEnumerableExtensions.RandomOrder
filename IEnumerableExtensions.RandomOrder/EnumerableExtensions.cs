using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions.RandomOrder
{
    /// <summary>
    /// IEnumerable Extension class to randomize the order of object/collection
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Extension method for public access
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            var range = new Random();
            return source.Randomize(range);
        }

        /// <summary>
        /// Private methods adds the range
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        private static IEnumerable<T> Randomize<T>(this IEnumerable<T> source, Random range)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (range == null) throw new ArgumentNullException("range");

            return source.RandomizeAlgorithm(range);
        }
        /// <summary>
        /// Private method which performs the swapping alogrithm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        private static IEnumerable<T> RandomizeAlgorithm<T>(this IEnumerable<T> source, Random range)
        {
            
            var temp = source.ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                int j = range.Next(i, temp.Count);
                yield return temp[j];
                temp[j] = temp[i];
            }
        }
    }
}
