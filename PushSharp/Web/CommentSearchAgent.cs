using PushSharp.Data;
using PushSharp.Search;
using PushSharp.Search.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Web
{
    public class CommentSearchAgent : RedditSearchAgent
    {
        public CommentSearchAgent(BaseSearchQuery query) : base(query)
        {
        }

        public List<Comment> GetResults()
        {
            var output = GetResults<Comment>();

            return output;
        }
    }
}
