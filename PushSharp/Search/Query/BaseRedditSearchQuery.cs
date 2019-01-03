using PushSharp.Search.Query.BaseParameters;
using PushSharp.Search.Query.RedditParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    /// <summary>
    /// A base class that holds the shared functionality for building a search query to serialize and send to the pushshift api.
    /// </summary>
    public abstract class BaseRedditSearchQuery
    {
        /// <summary>
        /// </summary>
        /// <param name="relativePath">The uri path relative to the 'https://pushshift.io/reddit' endpoint</param>
        public BaseRedditSearchQuery(string relativePath)
        {
            RelativePath = relativePath;
        }

        public const string PUSHSHIFT_REDDIT_ENDPOINT = "https://api.pushshift.io/reddit";

        public string RelativePath { get; protected set; }

        public LimitParameter Limit { get; set; }
        public SortEnumValueParameter Sort { get; set; }
        public SortTypeEnumValueParameter SortType { get; set; }
        public AfterParameter AfterDateTime { get; set; }
        public BeforeParameter BeforeDateTime { get; set; }
        public ScoreParameter Score { get; set; }
        public SubredditParameter Subreddit { get; set; }
        public BeforeIdParameter BeforeId { get; set; }
        public AfterIdParameter AfterId { get; set; }
        public CreatedUtcParameter CreatedUtc { get; set; }
        public GildedParameter Gilded { get; set; }
        public EditedParameter Edited { get; set; }
        public AuthorParameter Author { get; set; }
        public DistinguishedEnumParameter Distinguished { get; set; }
        public RetrievedOnParameter RetrievedOn { get; set; }
        public LastUpdatedParameter LastUpdated { get; set; }
        public QueryParameter Query { get; set; }
        public IdParameter Id { get; set; }
        //public MetaDataParameter MetaData { get; set; } // Not sure what this is yet, doc says 'Utility' for the type
        public UniqueParameter Unique { get; set; }
        public PrettyParameter Pretty { get; set; }
        public HtmlDecodeParameter HtmlDecode { get; set; }
        public PermalinkParameter Permalink { get; set; }
        public UserRemovedParameter UserRemoved { get; set; }
        public ModRemovedParameter ModRemoved { get; set; }
        public SubredditTypeParameter SubredditType { get; set; }
        public AuthorFlairCssClassParameter AuthorFlairCssClass { get; set; }
        public AuthorFlairTextParameter AuthorFlairText { get; set; }

        /// <summary>
        /// Builds the pushshift api url from the values in this object's properties.
        /// </summary>
        /// <returns>A pushshift api url</returns>
        public string GetRequestUrl()
        {
            var url = PUSHSHIFT_REDDIT_ENDPOINT + (
                RelativePath.StartsWith("/")
                ? RelativePath
                : "/" + RelativePath
                );

            var urlParameters = GetUrlParameters();

            if (urlParameters.Length > 0)
            {
                url = (!url.EndsWith("?") || !url.EndsWith("/") ? url + "/" : url); // Ensure the url has a trailing '/'
                url = (url.EndsWith("?") ? url : url + "?"); // Ensure the url has a trailing '?'
            }

            Uri output;
            bool isUrlBaseValid = Uri.TryCreate(url, UriKind.Absolute, out output) && (output.Scheme == Uri.UriSchemeHttps || output.Scheme == Uri.UriSchemeHttp);

            if (!isUrlBaseValid)
            {
                throw new ArgumentException($"Unable to create a valid HTTP url, check the value of {nameof(RelativePath)} '{RelativePath}'");
            }

            return url + urlParameters;
        }

        /// <summary>
        /// Builds the query parameter(s) part of the pushshift api url by reflecting on this classes public properties.
        /// </summary>
        /// <returns></returns>
        public string GetUrlParameters()
        {
            StringBuilder sb = new StringBuilder();
            var properties = GetType().GetProperties();

            foreach (var p in properties)
            {
                var o = p.GetValue(this, null);

                if (o is ValueParameter)
                {
                    var value = (ValueParameter)o;
                    if (value != null)
                    {
                        sb.Append(GetValueParameterAsHttpQueryString(value));
                        sb.Append("&");
                    }
                }
            }

            // Remove the trailing &
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Takes a <see cref="ValueParameter"/> object and formats it into an http safe GET query string.
        /// </summary>
        /// <returns>a string in the format of '{key}={value}'</returns>
        protected virtual string GetValueParameterAsHttpQueryString(ValueParameter target)
        {
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            var delimitedQueryString = target.ToString("=");
            var uriEscapedString = Uri.EscapeUriString(delimitedQueryString);

            return uriEscapedString;
        }
    }
}
