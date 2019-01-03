using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Query term for comments and submissions
    /// </summary>
    public class QueryParameter : StringValueParameter
    {
        public QueryParameter(string value) : base("q", value)
        {
        }

        public static implicit operator QueryParameter(string value)
        {
            return new QueryParameter(value);
        }
    }
}
