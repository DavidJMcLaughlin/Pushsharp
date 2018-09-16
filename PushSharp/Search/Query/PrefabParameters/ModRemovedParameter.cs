using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class ModRemovedParameter : BooleanValueParameter
    {
        public ModRemovedParameter(bool value) : base("mod_removed", value)
        {
        }
    }
}
