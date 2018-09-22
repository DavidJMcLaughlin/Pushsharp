using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class IdParameter : MultiValueParameter<string>
    {
        public IdParameter(string id) : base("id", new[] { id })
        {
        }

        public IdParameter(string[] ids) : base("id", ids)
        {
        }

        public static implicit operator IdParameter(string value)
        {
            return new IdParameter(value);
        }

        public static implicit operator IdParameter(string[] value)
        {
            return new IdParameter(value);
        }
    }
}
