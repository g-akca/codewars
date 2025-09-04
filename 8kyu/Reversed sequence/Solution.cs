using System;
using System.Linq;

public static class Kata
{
  public static int[] ReverseSeq(int n) => Enumerable.Range(1, n).Reverse().ToArray();
}