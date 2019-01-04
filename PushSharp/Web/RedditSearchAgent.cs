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
    public class RedditSearchAgent : IRedditApiSearchAgent
    {
        public RedditSearchAgent(IRetrieveHttpContent httpContentDownloader)
        {
            HttpContentDownloader = httpContentDownloader;
        }

        public IRetrieveHttpContent HttpContentDownloader { get; private set; }

        public RedditQueryResult<SubmissionSearchQuery, Submission> SearchSubmissions(SubmissionSearchQuery query)
        {
            return Search<SubmissionSearchQuery, Submission>(query);
        }

        public RedditQueryResult<CommentSearchQuery, Comment> SearchComments(CommentSearchQuery query)
        {
            return Search<CommentSearchQuery, Comment>(query);
        }

        public RedditQueryResult<T, K> Search<T, K>(T query)
            where T : BaseRedditSearchQuery
            where K : UserContent
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

            var returnedApiData = JsonConvert.DeserializeObject<List<K>>(jsonData);

            return new RedditQueryResult<T, K>(this, query, returnedApiData.ToArray());
        }
    }
}
