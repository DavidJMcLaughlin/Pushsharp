using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.BaseParameters
{
    /// <summary>
    /// A url parameter object that is limited to int values
    /// </summary>
    public class IntValueParameter : StringValueParameter
    {
        public IntValueParameter(string name, int value) : base(name, value.ToString())
        {
        }
    }
}
