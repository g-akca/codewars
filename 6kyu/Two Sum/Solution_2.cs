using System;
using System.Linq;

public class Kata
{
  public static int[] TwoSum(int[] numbers, int target) => 
    numbers.Select((v, i) => new int[] {i, Array.IndexOf(numbers, target - v, i + 1)})
           .First(v => v[1] > 0);
}