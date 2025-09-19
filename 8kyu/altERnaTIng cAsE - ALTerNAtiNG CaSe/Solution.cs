using System;
using System.Text;

namespace Extensions
{
  public static class StringExt
  {
    public static string ToAlternatingCase (this string s)
    {
      StringBuilder sb = new StringBuilder();
      foreach (char c in s) {
        if (Char.IsUpper(c)) {
          sb.Append(Char.ToLower(c));
        }
        else {
          sb.Append(Char.ToUpper(c));
        }
      }
      
      return sb.ToString();
    }
  }
}