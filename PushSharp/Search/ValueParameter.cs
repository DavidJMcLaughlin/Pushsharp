using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search
{
    public abstract class ValueParameter : INameValuePair
    {
        public abstract string Name { get; }

        public virtual string ToString(string separator)
        {
            return (Name + separator + GetValue());
        }

        public abstract string GetValue();
    }
}
