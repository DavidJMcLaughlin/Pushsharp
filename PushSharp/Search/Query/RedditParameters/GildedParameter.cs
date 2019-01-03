using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results based on this number of gildings or range of values
    /// </summary>
    public class GildedParameter : MultiValueParameter<int>
    {
        public GildedParameter(int gildedCount) : base("gilded", new[] { gildedCount })
        {
        }

        public GildedParameter(int[] gildedCountRange) : base("gilded", gildedCountRange)
        {
        }

        public static implicit operator GildedParameter(int value)
        {
            return new GildedParameter(value);
        }

        public static implicit operator GildedParameter(int[] value)
        {
            return new GildedParameter(value);
        }
    }
}
