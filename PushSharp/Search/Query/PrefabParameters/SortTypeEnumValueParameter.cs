using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class SortTypeEnumValueParameter : EnumValueParameter
    {
        public SortTypeEnumValueParameter(SortTypeValues value) : base("sort_type", typeof(SortTypeValues), value, x => x.GetAttributeOfType<EnumToStringValueAttribute>().Value)
        {
        }

        public static implicit operator SortTypeEnumValueParameter(SortTypeValues value)
        {
            return new SortTypeEnumValueParameter(value);
        }
    }

    public enum SortTypeValues
    {
        [EnumToStringValue("score")] Score,
        [EnumToStringValue("num_comments")] NumberOfComments,
        [EnumToStringValue("created_utc")] CreatedUtc
    }
}
