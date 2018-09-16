using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class NestLevelParameter : IntValueParameter
    {
        public NestLevelParameter(int value) : base("nest_level", value)
        {
        }
    }
}
