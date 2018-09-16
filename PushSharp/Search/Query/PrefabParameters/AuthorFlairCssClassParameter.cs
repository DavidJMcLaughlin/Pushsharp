using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class AuthorFlairCssClassParameter : StringValueParameter
    {
        public AuthorFlairCssClassParameter(string value) : base("author_flair_css_class", value)
        {
        }
    }
}
