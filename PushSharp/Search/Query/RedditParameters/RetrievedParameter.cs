using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results based on time ingested
    /// </summary>
    public class RetrievedOnParameter : EpochValueParameter
    {
        public RetrievedOnParameter(DateTime value) : base("retrieved_on", value)
        {
        }

        public static implicit operator RetrievedOnParameter(DateTime value)
        {
            return new RetrievedOnParameter(value);
        }
    }
}
