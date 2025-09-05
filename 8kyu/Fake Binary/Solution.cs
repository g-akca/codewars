using System;
using System.Text;

public class Kata
{
  public static string FakeBin(string x)
  {
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < x.Length; i++) {
      if (x[i] - '0' < 5) sb.Append("0");
      else sb.Append("1");
    }
    
    return sb.ToString();
  }
}