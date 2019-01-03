using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Extensions
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
    }
}
