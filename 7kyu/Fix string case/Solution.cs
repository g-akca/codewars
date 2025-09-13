using System;

class Kata
{
    public static string Solve(string s)
    {
      int upperCount = 0, lowerCount = 0;
      foreach (char c in s) {
        if (Char.IsUpper(c)) upperCount++;
        else if (Char.IsLower(c)) lowerCount++;
      }
      
      if (upperCount > lowerCount) return s.ToUpper();
      return s.ToLower();
    }
}