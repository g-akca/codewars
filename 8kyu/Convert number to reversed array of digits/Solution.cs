using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n) => n.ToString().Reverse().Select(c => (long)(c - '0')).ToArray();
  }
}