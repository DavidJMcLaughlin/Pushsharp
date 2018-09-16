using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    public abstract class ValueParameter : INameValuePair
    {
        public abstract string Name { get; protected set; }

        public virtual string ToString(string separator)
        {
            return (Name + separator + GetValueAsString());
        }

        public abstract string GetValueAsString();
    }
}
