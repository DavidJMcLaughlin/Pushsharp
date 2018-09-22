﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class UniqueParameter : FlagValueParameter
    {
        public UniqueParameter() : base("unique")
        {
        }

        public static implicit operator UniqueParameter(bool value)
        {
            if (value)
            {
                return new UniqueParameter();
            }

            return null;
        }
    }
}
