using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results based on this value or a range of values
    /// </summary>
    public class ScoreParameter : MultiValueParameter<int>
    {
        public ScoreParameter(int value) : base("score", new[] { value })
        {
        }

        public ScoreParameter(int[] values) : base("score", values)
        {
        }

        public static implicit operator ScoreParameter(int value)
        {
            return new ScoreParameter(value);
        }

        public static implicit operator ScoreParameter(int[] value)
        {
            return new ScoreParameter(value);
        }
    }
}
