using System;

public static class Kata
{
  public static string AddBinary(int a, int b)
  {
    int sum = a + b;
    string result = "";
    
    while (sum > 0) {
      int reminder = sum % 2;
      sum /= 2;
      result = $"{reminder}{result}";
    }
    
    return result;
  }
}