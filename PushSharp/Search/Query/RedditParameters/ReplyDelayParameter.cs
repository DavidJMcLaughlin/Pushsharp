using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict based on time elapsed in seconds when comment reply was made
    /// </summary>
    public class ReplyDelayParameter : EpochValueParameter
    {
        public ReplyDelayParameter(DateTime value) : base("reply_delay", value)
        {
        }

        public static implicit operator ReplyDelayParameter(DateTime value)
        {
            return new ReplyDelayParameter(value);
        }
    }
}
