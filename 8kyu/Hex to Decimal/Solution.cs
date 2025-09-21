using System;

public class Kata
{
  public static int HexToDec(string hexString) {
    bool isNegative = hexString.StartsWith("-");
    if (isNegative) hexString = hexString.Substring(1);

    int result = Convert.ToInt32(hexString, 16);
    return isNegative ? -result : result;
  }
}