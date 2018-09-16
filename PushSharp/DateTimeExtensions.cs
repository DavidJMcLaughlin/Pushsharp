using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp
{
    public static class DateTimeExtensions
    {
        private static DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static int ToUnixEpoch(this DateTime value)
        {
            var timespan = (value - UnixEpoch);
            return (int)timespan.TotalSeconds;
        }
    }
}
