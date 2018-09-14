using PushSharp.Search;
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
        protected const string PUSHSHIFT_REDDIT_ENDPOINT = "https://api.pushshift.io/reddit";

        protected WebClient _webClient = new WebClient();

        private StringBuilder _stringBuilder = new StringBuilder();



        protected string DownloadWebAddress(string url)
        {
            return _webClient.DownloadString(url);
        }

        protected string BuildUrl(string urlBase, IEnumerable<INameValuePair> urlAttributes)
        {
            Uri output;
            bool isUrlBaseValid = Uri.TryCreate(urlBase, UriKind.Absolute, out output) && (output.Scheme == Uri.UriSchemeHttps || output.Scheme == Uri.UriSchemeHttp);

            if (!isUrlBaseValid)
            {
                throw new ArgumentException($"{nameof(urlBase)} is not a valid HTTP url.");
            }

            var parameters = CombindNameValuePairs(urlAttributes);

            return (urlBase.EndsWith("?") ? urlBase + parameters : urlBase + "?" + parameters);
        }

        private string CombindNameValuePairs(IEnumerable<INameValuePair> pairs)
        {
            const string paramSeparator = "=";
            const char pairSeparator = '&';

            _stringBuilder.Clear();

            foreach (INameValuePair nvp in pairs)
            {
                _stringBuilder.Append(nvp.ToString(paramSeparator));
                _stringBuilder.Append(pairSeparator);
            }

            // Remove the trailing &
            _stringBuilder.Remove(_stringBuilder.Length - 1, 1);

            return _stringBuilder.ToString();
        }
    }
}
