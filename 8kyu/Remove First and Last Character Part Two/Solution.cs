using System;

public static class Kata
{
  public static string Array(string s)
  {
    string[] sub = s.Split(',');

    if (sub.Length <= 2) return null;

    return string.Join(" ", sub, 1, sub.Length - 2);
  }
}