using PushSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    /// <summary>
    /// A Pushshift query object thats only applicable to the submission search endpoint
    /// </summary>
    public class SubmissionSearchQuery : BaseRedditSearchQuery
    {
        public SubmissionSearchQuery() : base(RELATIVE_URL_PART)
        {
        }

        public const string RELATIVE_URL_PART = "/submission/search";

        public override BaseRedditSearchQuery DeepClone()
        {
            return this.CloneObjectWithIL();
        }
    }
}
