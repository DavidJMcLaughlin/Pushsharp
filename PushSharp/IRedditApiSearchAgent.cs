using PushSharp.Data;
using PushSharp.Search.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp
{
    public interface IRedditApiSearchAgent
    {
        RedditQueryResult<T, K> Search<T, K>(T searchQuery) 
            where K : UserContent 
            where T : BaseRedditSearchQuery;
    }
}
