using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class ScoreParameter : MultiValueParameter<int>
    {
        public ScoreParameter(int value) : base("score", new[] { value })
        {
        }

        public ScoreParameter(int[] values) : base("score", values)
        {
        }
    }
}
