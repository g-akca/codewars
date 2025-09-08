using System;
using System.Linq;

class Kata
{
    public static int StrCount(string str, char letter) => str.ToCharArray().Count(i => i == letter);
}