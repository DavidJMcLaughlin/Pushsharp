using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search
{
    public interface ISearchAgent
    {
        T[] GetResults<T>(IEnumerable<INameValuePair> searchParameters);
    }
}
