using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
    {
        public static int Number(List<int[]> peopleListInOut) => peopleListInOut.Sum(stop => stop[0] - stop[1]);
    }