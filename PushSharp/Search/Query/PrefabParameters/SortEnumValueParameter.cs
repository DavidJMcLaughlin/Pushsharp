using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class SortEnumValueParameter : EnumValueParameter
    {
        public SortEnumValueParameter(SortValues value) : base("sort", typeof(SortValues), value, x => x.GetAttributeOfType<EnumToStringValueAttribute>().Value)
        {
        }
    }

    public enum SortValues
    {
        [EnumToStringValue("asc")] Ascending,
        [EnumToStringValue("desc")] Descending
    }
}
