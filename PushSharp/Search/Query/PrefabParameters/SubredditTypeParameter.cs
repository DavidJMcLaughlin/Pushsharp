using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class SubredditTypeParameter : StringValueParameter
    {
        public SubredditTypeParameter(string value) : base("subreddit_type", value)
        {
        }
    }
}
