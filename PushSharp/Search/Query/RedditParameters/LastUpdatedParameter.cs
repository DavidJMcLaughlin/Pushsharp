using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results based on time updated
    /// </summary>
    public class LastUpdatedParameter : EpochValueParameter
    {
        public LastUpdatedParameter(DateTime value) : base("last_updated", value)
        {
        }

        public static implicit operator LastUpdatedParameter(DateTime value)
        {
            return new LastUpdatedParameter(value);
        }
    }
}
