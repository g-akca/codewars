namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
      int result = 0;
      foreach (int number in seq)
      {
        result ^= number;
      }
      return result;
      }
    }
}