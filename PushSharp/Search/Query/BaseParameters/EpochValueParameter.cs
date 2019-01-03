using PushSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.BaseParameters
{
    /// <summary>
    /// Turns a DateTime object into an int32 unix epoch value
    /// </summary>
    public abstract class EpochValueParameter : StringValueParameter
    {
        public EpochValueParameter(string name, DateTime value) : base(name, value.ToUnixEpoch().ToString())
        {
        }
    }
}
