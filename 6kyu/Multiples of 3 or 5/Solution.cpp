int solution(int number) 
{
  if (number < 0) return 0;
  
  number--;
  int mul_3 = (number - number % 3) / 3;
  int mul_5 = (number - number % 5) / 5;
  int mul_15 = (number - number % 15) / 15;
  
  int sum_3 = 3 * mul_3 * (mul_3 + 1) / 2;
  int sum_5 = 5 * mul_5 * (mul_5 + 1) / 2;
  int sum_15 = 15 * mul_15 * (mul_15 + 1) / 2;
  
  return sum_3 + sum_5 - sum_15;
}