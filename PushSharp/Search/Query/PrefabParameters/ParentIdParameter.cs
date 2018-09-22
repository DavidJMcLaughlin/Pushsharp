using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class ParentIdParameter : StringValueParameter
    {
        public ParentIdParameter(string value) : base("parent_id", value)
        {
        }

        public static implicit operator ParentIdParameter(string value)
        {
            return new ParentIdParameter(value);
        }
    }
}
