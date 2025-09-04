using System;
using System.Linq;

public static class Kata
{
  public static int[] ReverseSeq(int n) => Enumerable.Range(1, n).Select(i => i).OrderByDescending(i => i).ToArray();
}