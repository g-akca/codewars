using System.Linq;

public class Kata
{
  public static int[] DifferenceInAges(int[] ages)
  {
    int min = ages.Min();
    int max = ages.Max();
    return new int[] {min, max, max - min};
  }
}