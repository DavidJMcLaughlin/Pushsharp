using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    /// <summary>
    /// Limits the search to a set number of results, it appears 999 is the maximum results that can be returned in a single query
    /// </summary>
    public class LimitParameter : IntValueParameter
    {
        public LimitParameter(int value) : base("limit", value)
        {
        }

        public static implicit operator LimitParameter(int value)
        {
            return new LimitParameter(value);
        }
    }
}
