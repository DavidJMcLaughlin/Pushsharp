using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class RetrievedParameter : EpochValueParameter
    {
        public RetrievedParameter(DateTime value) : base("retrieved_on", value)
        {
        }

        public static implicit operator RetrievedParameter(DateTime value)
        {
            return new RetrievedParameter(value);
        }
    }
}
