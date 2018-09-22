using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// HTML decode the body of comments and selftext of submissions
    /// </summary>
    public class HtmlDecodeParameter : FlagValueParameter
    {
        public HtmlDecodeParameter() : base("html_decode")
        {
        }

        public static implicit operator HtmlDecodeParameter(bool value)
        {
            if (value)
            {
                return new HtmlDecodeParameter();
            }

            return null;
        }
    }
}
