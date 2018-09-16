using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class LastUpdatedParameter : EpochValueParameter
    {
        public LastUpdatedParameter(DateTime value) : base("last_updated", value)
        {
        }
    }
}
