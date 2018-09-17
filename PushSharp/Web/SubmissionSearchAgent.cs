using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PushSharp.Data;
using PushSharp.Search;
using PushSharp.Search.Query;

namespace PushSharp.Web
{
    public class SubmissionSearchAgent : RedditSearchAgent
    {
        public SubmissionSearchAgent(BaseSearchQuery query) : base(query)
        {
        }

        public List<Submission> GetResults()
        {
            var output = GetResults<Submission>();

            return output;
        }
    }
}
