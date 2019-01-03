using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    public abstract class EnumValueParameter : StringValueParameter
    {
        public EnumValueParameter(string name, Type enumType, Enum value) : this(name, enumType, value, v => v.ToString())
        {
        }
        public EnumValueParameter(string name, Type enumType, Enum value, Func<Enum, string> valueToStringConverter) : base(name)
        {
            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"Parameter '{nameof(enumType)}' is not an enum type");
            }

            if (!Enum.IsDefined(enumType, value))
            {
                throw new ArgumentException($"Parameter '{nameof(value)}' is not contained in '{nameof(enumType)}'");
            }

            if (valueToStringConverter == null)
            {
                throw new ArgumentNullException(nameof(valueToStringConverter));
            }

            _Value = valueToStringConverter(value);
        }
    }
}
