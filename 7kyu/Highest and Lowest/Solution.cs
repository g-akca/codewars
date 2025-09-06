using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers) {
    string[] arr = numbers.Split(' ');
    int[] arr2 = Array.ConvertAll(arr, int.Parse);
    return $"{arr2.Max()} {arr2.Min()}";
  }
}