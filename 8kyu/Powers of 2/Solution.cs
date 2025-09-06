using System.Numerics;
using System.Linq;

public class Kata
{
  public static BigInteger[] PowersOfTwo(int n) => Enumerable.Range(0, n + 1).Select(i => BigInteger.Pow(2, i)).ToArray();
}