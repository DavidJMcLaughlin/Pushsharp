using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class QueryParameter : StringValueParameter
    {
        public QueryParameter(string value) : base("q", value)
        {
        }
    }
}
