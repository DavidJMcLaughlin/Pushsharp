using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class DistinguishedEnumParameter : EnumValueParameter
    {
        public DistinguishedEnumParameter(DistinguishedValues value) : base("distinguished", typeof(DistinguishedValues), value)
        {
        }
    }

    public enum DistinguishedValues
    {
        [EnumToStringValue("admin")] Admin,
        [EnumToStringValue("moderator")] Moderator
    }
}
