using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query
{
    public class SubmissionSearchQuery : BaseSearchQuery
    {
        public SubmissionSearchQuery() : base(RELATIVE_URL_PART)
        {
        }

        public const string RELATIVE_URL_PART = "/submission/search";
    }
}
