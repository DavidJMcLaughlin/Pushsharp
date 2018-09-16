using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class BeforeIdParameter : StringValueParameter
    {
        public BeforeIdParameter(string value) : base("before_id", value)
        {
        }
    }
}
