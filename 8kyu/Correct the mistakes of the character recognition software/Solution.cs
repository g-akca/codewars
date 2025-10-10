using System.Text;

public class Kata
{
  public static string Correct(string text)
  {
    StringBuilder sb = new StringBuilder();
    foreach (char c in text) {
      if (c == '5') sb.Append('S');
      else if (c == '0') sb.Append('O');
      else if (c == '1') sb.Append('I');
      else sb.Append(c);
    }
    return sb.ToString();
  }
}