using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict based on nest level of comment. 1 is a top level comment
    /// </summary>
    public class NestLevelParameter : IntValueParameter
    {
        public NestLevelParameter(int value) : base("nest_level", value)
        {
        }

        public static implicit operator NestLevelParameter(int value)
        {
            return new NestLevelParameter(value);
        }
    }
}
