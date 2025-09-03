public class Kata
{
  public static int FindShort(string s)
  {
    string[] words = s.Split(' ');
    int min = words[0].Length;
    foreach (var word in words) {
      if (word.Length < min) min = word.Length;
    }
    return min;
  }
}