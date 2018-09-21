using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Web
{
    internal class BasicHttpContentDownloader : IRetrieveHttpContent
    {
        protected WebClient _webClient = new WebClient();

        public byte[] GetUrlContent(string url)
        {
            return _webClient.DownloadData(url);
        }
    }
}
