using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Prettify the JSON output
    /// </summary>
    public class PrettyParameter : FlagValueParameter
    {
        public PrettyParameter() : base("pretty")
        {
        }

        public static implicit operator PrettyParameter(bool value)
        {
            if (value)
            {
                return new PrettyParameter();
            }

            return null;
        }
    }
}
