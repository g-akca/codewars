using System;

public static class Kata
{
 public static string Usdcny(int usd) => $"{usd * 6.75:N2} Chinese Yuan".Replace(",", "");
}