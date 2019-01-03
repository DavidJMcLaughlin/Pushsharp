using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results to only include one of each of specific field
    /// </summary>
    public class UniqueParameter : FlagValueParameter
    {
        public UniqueParameter() : base("unique")
        {
        }

        public static implicit operator UniqueParameter(bool value)
        {
            if (value)
            {
                return new UniqueParameter();
            }

            return null;
        }
    }
}
