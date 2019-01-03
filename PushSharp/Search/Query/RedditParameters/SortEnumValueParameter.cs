using PushSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Sort direction of results ("asc" or "desc")
    /// </summary>
    public class SortEnumValueParameter : EnumValueParameter
    {
        public SortEnumValueParameter(SortValues value) : base("sort", typeof(SortValues), value, x => x.GetAttributeOfType<EnumToStringValueAttribute>().Value)
        {
        }

        public static implicit operator SortEnumValueParameter(SortValues value)
        {
            return new SortEnumValueParameter(value);
        }
    }

    public enum SortValues
    {
        [EnumToStringValue("asc")] Ascending,
        [EnumToStringValue("desc")] Descending
    }
}
