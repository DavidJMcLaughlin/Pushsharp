using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
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
