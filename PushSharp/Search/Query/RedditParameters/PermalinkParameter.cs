using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results to those with this value
    /// </summary>
    public class PermalinkParameter : StringValueParameter
    {
        public PermalinkParameter(string value) : base("permalink", value)
        {
        }
    }
}
