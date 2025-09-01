namespace Solution
{
  class Kata
    {
      public static int binaryArrayToNumber(int[] BinaryArray)
        {
          int exp = 1, result = 0;
          for (int i = BinaryArray.Length - 1; i >= 0; i--) {
            result += BinaryArray[i] * exp;
            exp *= 2;
          }
        
        return result;
        }
    }
}