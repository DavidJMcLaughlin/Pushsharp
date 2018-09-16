﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search
{
    public interface INameValuePair
    {
        string Name { get; }
        string GetValueAsString();

        string ToString(string separator);
    }
}
