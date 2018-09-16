using Newtonsoft.Json;
using PushSharp.Search;
using PushSharp.Search.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Web
{
    public abstract class RedditSearchAgent
    {
        public RedditSearchAgent(BaseSearchQuery query)
        {
            Query = query;
        }

        public BaseSearchQuery Query { get; set; }

        protected WebClient _webClient = new WebClient();
        private StringBuilder _stringBuilder = new StringBuilder();

        public virtual T[] GetResults<T>()
        {
            var url = Query.GetRequestUrl();
            var pageData = DownloadWebAddress(url);

            return JsonConvert.DeserializeObject<T[]>(pageData);
        }

        protected string DownloadWebAddress(string url)
        {
            return _webClient.DownloadString(url);
        }
    }
}
