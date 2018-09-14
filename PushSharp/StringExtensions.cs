using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp
{
    internal static class StringExtensions
    {
        internal static string Combine(this string part1, string part2, string separatorText, string preText, string postText)
        {
            return preText + part1 + separatorText + part2 + postText;
        }

        internal static string Combine(this string part1, string part2, string separatorText, string preText)
        {
            return part1.Combine(part2, separatorText, preText, string.Empty);
        }

        internal static string Combine(this string part1, string part2, string separatorText)
        {
            return part1.Combine(part2, separatorText, string.Empty, string.Empty);
        }

        internal static string Combine(this string[] array, string separatorText)
        {
            if (array == null || array.Length < 1)
            {
                throw new ArgumentNullException(nameof(array), "Argument is null or empty");
            }

            if (array.Length == 1)
            {
                // Only a single value array
                return array[0];
            }

            var output = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                output = output.Combine(array[i], separatorText);
            }

            return output;
        }
    }
}
