using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
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
