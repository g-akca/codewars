using System.Linq;

class Kata
{
    public static int StrCount(string str, char letter) => str.Count(i => i == letter);
}