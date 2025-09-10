using System;
using System.Linq;

public static class StringExtensions
{
  public static bool IsUpperCase(this string text) => text.All(c => Char.IsUpper(c) || !Char.IsLetter(c));
}