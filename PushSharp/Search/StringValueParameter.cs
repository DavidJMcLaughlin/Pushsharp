using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search
{
    public abstract class StringValueParameter : ValueParameter
    {
        public StringValueParameter(string value)
        {
            _Value = value;
        }

        protected string _Value = string.Empty;

        public override string GetValue()
        {
            return _Value;
        }
    }
}
