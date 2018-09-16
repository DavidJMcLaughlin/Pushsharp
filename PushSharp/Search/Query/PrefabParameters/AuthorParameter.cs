using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class AuthorParameter : MultiValueParameter<string>
    {
        public AuthorParameter(string author) : base("author", new[] { author })
        {
        }

        public AuthorParameter(string[] authors) : base("author", authors)
        {
        }
    }
}
