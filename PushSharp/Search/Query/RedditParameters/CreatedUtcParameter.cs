using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results based on the epoch value given or range of values
    /// </summary>
    public class CreatedUtcParameter : MultiValueParameter<int>
    {
        public CreatedUtcParameter(int createdUtc) : base("created_utc", new[] { createdUtc })
        {
        }

        public CreatedUtcParameter(int[] createdUtcRange) : base("created_utc", createdUtcRange)
        {
        }

        public static implicit operator CreatedUtcParameter(int value)
        {
            return new CreatedUtcParameter(value);
        }

        public static implicit operator CreatedUtcParameter(int[] value)
        {
            return new CreatedUtcParameter(value);
        }
    }
}
