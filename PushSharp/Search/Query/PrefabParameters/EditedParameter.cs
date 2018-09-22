using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
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
