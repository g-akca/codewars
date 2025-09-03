using System.Text;

public class Kata
{
  public static string DoubleChar(string s)
  {
    StringBuilder sb = new StringBuilder("");
    foreach (char c in s) {
      sb.AppendFormat("{0}{1}", c, c);
    }
    return sb.ToString();
  }
}