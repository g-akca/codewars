public class Kata
{
  public static int DutyFree(int normPrice, int Discount, int hol) => (int)(hol / (normPrice * Discount / 100.0));
}