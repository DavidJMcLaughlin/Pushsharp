using PushSharp.Search.Query.RedditParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PushSharp.Extensions;

namespace PushSharp.Search.Query
{
    /// <summary>
    /// A Pushshift query object thats only applicable to the comment search endpoint
    /// </summary>
    public class CommentSearchQuery : BaseRedditSearchQuery
    {
        public CommentSearchQuery() : base(RELATIVE_URL_PART)
        {
        }

        public const string RELATIVE_URL_PART = "/comment/search";

        public ReplyDelayParameter ReplyDelay { get; set; }
        public NestLevelParameter NestLevel { get; set; }
        public SubReplyDelayParameter SubReplyDelay { get; set; }
        public UtcHourOfWeekParameter UtcHourOfWeek { get; set; }
        public LinkIdParameter LinkId { get; set; }
        public ParentIdParameter ParentId { get; set; }

        public override BaseRedditSearchQuery DeepClone()
        {
            return this.CloneObjectWithIL();
        }
    }
}
