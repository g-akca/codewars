using System.Linq;

public class Kata {
  public static int[] Between(int a, int b) => Enumerable.Range(a, b - a + 1).ToArray();
}