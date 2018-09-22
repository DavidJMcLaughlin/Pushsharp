using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false)]
    public class EnumToStringValueAttribute : Attribute
    {
        public EnumToStringValueAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; private set; }
    }
}
