using Newtonsoft.Json.Linq;
using PushSharp.Data;
using PushSharp.Search.Query;
using PushSharp.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp
{
    public class PushshiftApi
    {
        /// <summary>
        /// The Pushshift.io reddit endpoint
        /// </summary>
        public RedditSearchAgent Reddit { get; private set; } = new RedditSearchAgent(new BasicHttpContentDownloader());
    }
}
