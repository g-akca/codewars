using System;
namespace Solution
{
  public static class Program
  {
    public static string StringsSum(string s1, string s2) {
      int i1 = String.IsNullOrEmpty(s1) ? 0 : Int32.Parse(s1);
      int i2 = String.IsNullOrEmpty(s2) ? 0 : Int32.Parse(s2);
      return (i1 + i2).ToString(); 
    }
  }
}