using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results made by an admin / moderator / etc
    /// </summary>
    public class DistinguishedEnumParameter : EnumValueParameter
    {
        public DistinguishedEnumParameter(DistinguishedValues value) : base("distinguished", typeof(DistinguishedValues), value)
        {
        }

        public static implicit operator DistinguishedEnumParameter(DistinguishedValues value)
        {
            return new DistinguishedEnumParameter(value);
        }
    }

    public enum DistinguishedValues
    {
        [EnumToStringValue("admin")] Admin,
        [EnumToStringValue("moderator")] Moderator
    }
}
