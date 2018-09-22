using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class AuthorFlairTextParameter : StringValueParameter
    {
        public AuthorFlairTextParameter(string value) : base("author_flair_text", value)
        {
        }

        public static implicit operator AuthorFlairTextParameter(string value)
        {
            return new AuthorFlairTextParameter(value);
        }
    }
}
