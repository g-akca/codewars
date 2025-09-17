public class Kata
{
  public static char Grader(double score)
  {
    switch (score) {
      case > 1:
        return 'F';
      case >= 0.9:
        return 'A';
      case >= 0.8:
        return 'B';
      case >= 0.7:
        return 'C';
      case >= 0.6:
        return 'D';
      default:
        return 'F';
    }
  }
}