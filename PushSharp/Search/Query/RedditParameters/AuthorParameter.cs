using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results to author (use "!" to negate, comma delimited for multiples)
    /// </summary>
    public class AuthorParameter : MultiValueParameter<string>
    {
        public AuthorParameter(string author) : base("author", new[] { author })
        {
        }

        public AuthorParameter(string[] authors) : base("author", authors)
        {
        }

        public static implicit operator AuthorParameter(string value)
        {
            return new AuthorParameter(value);
        }

        public static implicit operator AuthorParameter(string[] value)
        {
            return new AuthorParameter(value);
        }
    }
}
