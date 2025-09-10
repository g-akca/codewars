using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> FindMultiples(int n, int limit) => Enumerable.Range(1, limit / n).Select(x => x * n).ToList();
}