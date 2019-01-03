using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict based on number of seconds elapsed from when submission was made
    /// </summary>
    public class SubReplyDelayParameter : EpochValueParameter
    {
        public SubReplyDelayParameter(DateTime value) : base("sub_reply_delay", value)
        {
        }

        public static implicit operator SubReplyDelayParameter(DateTime value)
        {
            return new SubReplyDelayParameter(value);
        }
    }
}
