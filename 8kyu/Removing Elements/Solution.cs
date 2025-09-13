using System.Linq;

public static class Kata
{
  public static object[] RemoveEveryOther(object[] arr) => arr.Where((item, index) => index % 2 == 0).ToArray();
}