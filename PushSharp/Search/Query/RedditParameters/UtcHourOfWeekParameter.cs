using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict based on hour of week when comment was made (for aggregations)
    /// </summary>
    public class UtcHourOfWeekParameter : EpochValueParameter
    {
        public UtcHourOfWeekParameter(DateTime value) : base("utc_hour_of_week", value)
        {
        }

        public static implicit operator UtcHourOfWeekParameter(DateTime value)
        {
            return new UtcHourOfWeekParameter(value);
        }
    }
}
