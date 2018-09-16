using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    public class BooleanValueParameter : StringValueParameter
    {
        public BooleanValueParameter(string name, bool value) : base(name, value.ToString().ToLowerInvariant())
        {
        }
    }
}
