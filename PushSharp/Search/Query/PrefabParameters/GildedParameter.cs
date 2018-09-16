using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Search.Query.PrefabParameters
{
    public class GildedParameter : MultiValueParameter<int>
    {
        public GildedParameter(int gildedCount) : base("gilded", new[] { gildedCount })
        {
        }

        public GildedParameter(int[] gildedCountRange) : base("gilded", gildedCountRange)
        {
        }
    }
}
