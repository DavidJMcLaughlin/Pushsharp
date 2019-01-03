using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results to those made after this epoch time
    /// </summary>
    public class AfterParameter : EpochValueParameter
    {
        public AfterParameter(DateTime value) : base("after", value)
        {
        }

        public static implicit operator AfterParameter(DateTime value)
        {
            return new AfterParameter(value);
        }
    }
}
