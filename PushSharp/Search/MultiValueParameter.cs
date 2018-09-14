using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search
{
    public abstract class MultiValueParameter<T> : ValueParameter
    {
        public MultiValueParameter(params T[] values)
        {
            _Values = values;
        }

        protected T[] _Values = new T[0];

        public override string GetValue()
        {
            
        }
    }
}
