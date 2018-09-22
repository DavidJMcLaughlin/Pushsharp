using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.RedditParameters
{
    /// <summary>
    /// Restrict results to those that were edited by the user
    /// </summary>
    public class EditedParameter : BooleanValueParameter
    {
        public EditedParameter(bool edited) : base("edited", edited)
        {
        }

        public static implicit operator EditedParameter(bool value)
        {
            return new EditedParameter(value);
        }
    }
}
