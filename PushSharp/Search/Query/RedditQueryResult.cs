using PushSharp.Data;
using PushSharp.Search.Query.RedditParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    public class RedditQueryResult<T, K> 
        where T : BaseRedditSearchQuery
        where K : UserContent
    {
        public RedditQueryResult(IRedditApiSearchAgent provider, T query, params K[] values)
        {
            _searchAgent = provider ?? throw new ArgumentNullException(nameof(provider));
            Query = query ?? throw new ArgumentNullException(nameof(query));

            HasValue = (values != null && values.Length > 0);
            ValueList.AddRange(values);
        }

        protected IRedditApiSearchAgent _searchAgent;
        

        public bool HasValue { get; protected set; }
        public List<K> ValueList { get; private set; } = new List<K>();
        public T Query { get; private set; }

        /// <summary>
        /// Gets a new <see cref="RedditQueryResult{T, K}"> that contains results from chronologically prior to the last value in the ValueList.
        /// </summary>
        /// <returns></returns>
        public RedditQueryResult<T, K> GetNextPageOfResults()
        {
            if (!HasValue)
            {
                // This will return with HasValue == false
                return new RedditQueryResult<T, K>(_searchAgent, Query, null);
            }

            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var q = (T)Query.DeepClone();

            // We need to +1 here so we don't miss any results.
            // PushShift has a limit of items they will return, so there is a case
            // where if the ValueList.Last() item isn't the last item to have that timestamp
            // then we could unintentionally miss some items.
            // For instance, say PushShift has 10 items that all share a timestamp.
            // We make a request for say 25 items and get 20 that are not in the above 10 that share a timestamp,
            // if we say 'give me everything before the timestamp of the last item in my list' we'll never see those last 5 items.
            // However now we have a case where if the list of items that share a timestamp is >= the limit (-1)
            // that PushShare will serve us, then we may get stuck on a page with this method...
            // Will need to check if PushSharp has added better support for paging, at this time this seems to be the only way.
            var targetDateTime = epoch.AddSeconds((ValueList.Last().CreatedUtc + 1));
            q.BeforeDateTime = new BeforeParameter(targetDateTime);

            return _searchAgent.Search<T, K>(q);
        }
    }
}
