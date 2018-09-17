using PushSharp.Search.Query.PrefabParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    public abstract class BaseSearchQuery
    {
        public BaseSearchQuery(string relativePath)
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
        public RetrievedParameter RetrievedOn { get; set; }
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
                url = (!url.EndsWith("?") || !url.EndsWith("/") ? url + "/" : url);
                url = (url.EndsWith("?") ? url : url + "?");
            }

            Uri output;
            bool isUrlBaseValid = Uri.TryCreate(url, UriKind.Absolute, out output) && (output.Scheme == Uri.UriSchemeHttps || output.Scheme == Uri.UriSchemeHttp);

            if (!isUrlBaseValid)
            {
                throw new ArgumentException($"Unable to create a valid HTTP url, check the value of {nameof(RelativePath)} '{RelativePath}'");
            }

            return url + urlParameters;
        }

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
                        sb.Append(Uri.EscapeUriString(value.ToString("=")));
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
    }
}
