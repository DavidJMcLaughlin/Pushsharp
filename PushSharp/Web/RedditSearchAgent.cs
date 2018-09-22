using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PushSharp.Data;
using PushSharp.Search.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Web
{
    /// <summary>
    /// This class encapsulates access to all Pushshift reddit endpoints
    /// </summary>
    public class RedditSearchAgent
    {
        public RedditSearchAgent(IRetrieveHttpContent httpContentDownloader)
        {
            HttpContentDownloader = httpContentDownloader;
        }

        public IRetrieveHttpContent HttpContentDownloader { get; private set; }

        public List<Submission> SearchSubmissions(SubmissionSearchQuery query)
        {
            return SearchPushshift<Submission>(query);
        }

        public List<Comment> SearchComments(CommentSearchQuery query)
        {
            return SearchPushshift<Comment>(query);
        }

        private List<T> SearchPushshift<T>(BaseRedditSearchQuery query)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            var url = query.GetRequestUrl();
            var pageBytes = HttpContentDownloader.GetUrlContent(url);

            if (pageBytes == null || pageBytes.Length == 0)
            {
                throw new NullReferenceException($"Request returned no data for '{url}'");
            }

            var pageString = Encoding.UTF8.GetString(pageBytes);

            var jo = JObject.Parse(pageString);

            if (!jo.HasValues)
            {
                throw new JsonException($"Request returned an empty json string for '{url}'");
            }

            var jsonData = jo["data"].ToString();

            return JsonConvert.DeserializeObject<List<T>>(jsonData);
        }
    }
}
