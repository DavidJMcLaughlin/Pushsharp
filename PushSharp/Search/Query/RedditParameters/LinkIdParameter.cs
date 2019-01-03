using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results based on submission id
    /// </summary>
    public class LinkIdParameter : StringValueParameter
    {
        public LinkIdParameter(string value) : base("link_id", value)
        {
        }

        public static implicit operator LinkIdParameter(string value)
        {
            return new LinkIdParameter(value);
        }
    }
}
