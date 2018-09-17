using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    /// <summary>
    /// A url parameter object that is limited to string values
    /// </summary>
    public class StringValueParameter : ValueParameter
    {
        public StringValueParameter(string name) : this(name, string.Empty)
        {
        }
        public StringValueParameter(string name, string value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"Parameter '{nameof(name)}' cannot be null or empty");
            }

            _Value = value;
            Name = name;
        }

        protected string _Value = string.Empty;

        public override string Name { get; protected set; }

        public override string GetValueAsString()
        {
            return _Value;
        }
    }
}
