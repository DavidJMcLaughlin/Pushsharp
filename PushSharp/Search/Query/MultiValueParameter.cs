using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    /// <summary>
    /// A url parameter that turns a collection of values into a comma separated string
    /// </summary>
    /// <typeparam name="T">The type this object should store/accept</typeparam>
    public class MultiValueParameter<T> : ValueParameter
    {
        public MultiValueParameter(string name, T[] values)
        {
            Name = name;
            _Values = values;
        }

        private const string VALUE_SEPARATOR = ",";

        protected T[] _Values = new T[0];

        public T this[int i]
        {
            get
            {
                return _Values[i];
            }
        }

        public override string Name { get; protected set; }

        public override string GetValueAsString()
        {
            return _Values.CombineToString(VALUE_SEPARATOR);
        }
    }
}
