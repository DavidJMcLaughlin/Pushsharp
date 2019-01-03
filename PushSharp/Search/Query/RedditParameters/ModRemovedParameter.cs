using PushSharp.Search.Query.BaseParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results based on if a moderator removed this object
    /// </summary>
    public class ModRemovedParameter : BooleanValueParameter
    {
        public ModRemovedParameter(bool value) : base("mod_removed", value)
        {
        }

        public static implicit operator ModRemovedParameter(bool value)
        {
            return new ModRemovedParameter(value);
        }
    }
}
