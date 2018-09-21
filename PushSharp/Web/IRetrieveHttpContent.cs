using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Web
{
    public interface IRetrieveHttpContent
    {
        byte[] GetUrlContent(string url);
    }
}
