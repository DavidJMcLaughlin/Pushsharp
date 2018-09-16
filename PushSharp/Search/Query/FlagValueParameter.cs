using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    /// <summary>
    /// A flag value is a url get parameter with no value (e.g. www.example.com/search?flagParameter=&query=searchTextHere)
    /// </summary>
    public class FlagValueParameter : StringValueParameter
    {
        public FlagValueParameter(string name) : base(name, string.Empty)
        {
        }
    }
}
