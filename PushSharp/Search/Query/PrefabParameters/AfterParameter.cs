using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class AfterParameter : EpochValueParameter
    {
        public AfterParameter(DateTime value) : base("after", value)
        {
        }
    }
}
