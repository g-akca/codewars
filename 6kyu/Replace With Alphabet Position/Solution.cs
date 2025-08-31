using System;
using System.Collections.Generic;

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    List<string> numbers = new List<string>();
    
    foreach (char c in text) {
      if (Char.IsLetter(c)) {
        numbers.Add((Char.ToLower(c) - 'a' + 1).ToString());
      }
    }
    
    return string.Join(" ", numbers);
  }
}