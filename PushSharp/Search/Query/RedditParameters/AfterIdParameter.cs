using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results to those with an id greater than this value
    /// </summary>
    public class AfterIdParameter : StringValueParameter
    {
        public AfterIdParameter(string value) : base("after_id", value)
        {
        }

        public static implicit operator AfterIdParameter(string value)
        {
            return new AfterIdParameter(value);
        }
    }
}
