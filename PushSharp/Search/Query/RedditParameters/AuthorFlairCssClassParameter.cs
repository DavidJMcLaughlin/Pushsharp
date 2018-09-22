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
    public class AuthorFlairCssClassParameter : StringValueParameter
    {
        public AuthorFlairCssClassParameter(string value) : base("author_flair_css_class", value)
        {
        }

        public static implicit operator AuthorFlairCssClassParameter(string value)
        {
            return new AuthorFlairCssClassParameter(value);
        }
    }
}
