using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results based on if a user removed this object
    /// </summary>
    public class UserRemovedParameter : BooleanValueParameter
    {
        public UserRemovedParameter(bool value) : base("user_removed", value)
        {
        }

        public static implicit operator UserRemovedParameter(bool value)
        {
            return new UserRemovedParameter(value);
        }
    }
}
