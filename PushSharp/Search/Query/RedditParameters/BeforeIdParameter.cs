using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results to those with an id less than this value
    /// </summary>
    public class BeforeIdParameter : StringValueParameter
    {
        public BeforeIdParameter(string value) : base("before_id", value)
        {
        }

        public static implicit operator BeforeIdParameter(string value)
        {
            return new BeforeIdParameter(value);
        }
    }
}
