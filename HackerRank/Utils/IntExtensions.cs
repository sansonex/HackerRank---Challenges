using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Utils
{
    static class IntExtensions
    {
        public static bool IsBetween(this int value, int start, int end)
        {
            return value >= start && value <= end;
        }
    }
}
