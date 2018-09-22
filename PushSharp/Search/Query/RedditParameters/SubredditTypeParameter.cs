using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results based on subreddit type
    /// </summary>
    public class SubredditTypeParameter : StringValueParameter
    {
        public SubredditTypeParameter(string value) : base("subreddit_type", value)
        {
        }

        public static implicit operator SubredditTypeParameter(string value)
        {
            return new SubredditTypeParameter(value);
        }
    }
}
