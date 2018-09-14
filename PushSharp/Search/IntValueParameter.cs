using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search
{
    public abstract class IntValueParameter : StringValueParameter
    {
        public IntValueParameter(int value) : base(value.ToString())
        {
        }
    }
}
