using PushSharp.Search.Query.PrefabParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    public class CommentSearchQuery : BaseSearchQuery
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
    }
}
