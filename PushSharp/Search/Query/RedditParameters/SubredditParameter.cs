using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results to subreddit (use "!" to negate, comma delimited for multiples)
    /// </summary>
    public class SubredditParameter : MultiValueParameter<string>
    {
        public SubredditParameter(string subreddit) : base("subreddit", new[] { subreddit })
        {
        }

        public SubredditParameter(string[] subreddits) : base("subreddit", subreddits)
        {
        }

        public static implicit operator SubredditParameter(string value)
        {
            return new SubredditParameter(value);
        }

        public static implicit operator SubredditParameter(string[] value)
        {
            return new SubredditParameter(value);
        }
    }
}
