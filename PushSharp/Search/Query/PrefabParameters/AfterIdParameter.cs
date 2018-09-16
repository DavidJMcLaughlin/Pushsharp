using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class AfterIdParameter : StringValueParameter
    {
        public AfterIdParameter(string value) : base("after_id", value)
        {
        }
    }
}
