using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    public abstract class EpochValueParameter : StringValueParameter
    {
        public EpochValueParameter(string name, DateTime value) : base(name, value.ToUnixEpoch().ToString())
        {
        }
    }
}
