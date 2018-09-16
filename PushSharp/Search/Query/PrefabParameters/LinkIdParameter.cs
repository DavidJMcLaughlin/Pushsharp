﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class LinkIdParameter : StringValueParameter
    {
        public LinkIdParameter(string value) : base("link_id", value)
        {
        }
    }
}
