using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class CreatedUtcParameter : MultiValueParameter<int>
    {
        public CreatedUtcParameter(int createdUtc) : base("created_utc", new[] { createdUtc })
        {
        }

        public CreatedUtcParameter(int[] createdUtcRange) : base("created_utc", createdUtcRange)
        {
        }
    }
}
