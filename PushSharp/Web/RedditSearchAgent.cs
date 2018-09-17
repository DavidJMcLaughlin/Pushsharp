using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        protected List<T> GetResults<T>()
        {
            var url = Query.GetRequestUrl();
            var pageData = DownloadWebAddress(url);

            if (string.IsNullOrEmpty(pageData))
            {
                throw new NullReferenceException($"Request returned no data for '{url}'");
            }

            var jo = JObject.Parse(pageData);

            if (!jo.HasValues)
            {
                throw new JsonException($"Request returned an empty json string for '{url}'");
            }

            return JsonConvert.DeserializeObject<List<T>>(jo["data"].ToString());
        }

        protected string DownloadWebAddress(string url)
        {
            return _webClient.DownloadString(url);
        }
    }
}
