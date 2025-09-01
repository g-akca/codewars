using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    if (pin.Length != 4 && pin.Length != 6) return false;

    foreach (char c in pin)
    {
      if (!Char.IsDigit(c)) return false;
    }

    return true;
  }
}