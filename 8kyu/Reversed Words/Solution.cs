using System;
using System.Linq;

public class Kata
{
  public static string ReverseWords(string str) => String.Join(' ', str.Split(' ').Reverse());
}