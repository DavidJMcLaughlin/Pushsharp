using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results to those made before this epoch time
    /// </summary>
    public class BeforeParameter : EpochValueParameter
    {
        public BeforeParameter(DateTime value) : base("before", value)
        {
        }

        public static implicit operator BeforeParameter(DateTime value)
        {
            return new BeforeParameter(value);
        }
    }
}
