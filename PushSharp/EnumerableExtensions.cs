using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp
{
    internal static class EnumerableExtensions
    {
        /// <summary>
        /// Turns the values in an IEnumerable into a delimited string
        /// </summary>
        /// <typeparam name="T">The IEnumerable type</typeparam>
        /// <param name="array">The target IEnumerable</param>
        /// <param name="delimiter">The delimiter value to insert between values in the target IEnumerable</param>
        /// <returns>A delimited string containing all the values in the target IEnumerable. If the IEnumerable only contains a single value then only that value is returned with no delimiter</returns>
        internal static string CombineToString<T>(this IEnumerable<T> array, string delimiter)
        {
            int count = array.Count();

            if (array == null || count < 1)
            {
                throw new ArgumentNullException(nameof(array), "Argument is null or empty");
            }

            if (count == 1)
            {
                // Only a single value array
                return array.First().ToString();
            }

            var output = array.First().ToString();

            int i = 0;
            foreach (T item in array)
            {
                if (i > 0)
                {
                    output = output.Combine(item.ToString(), delimiter);
                }

                i++;
            }

            return output;
        }
    }
}
