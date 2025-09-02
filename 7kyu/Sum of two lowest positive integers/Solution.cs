public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
	  int min_1 = int.MaxValue, min_2 = int.MaxValue;
    for (int i = 0; i < numbers.Length; i++) {
      if (numbers[i] < min_1) {
        min_2 = min_1;
        min_1 = numbers[i];
      }
      else if (numbers[i] < min_2) min_2 = numbers[i];
    }
    
    return min_1 + min_2;
	}
}