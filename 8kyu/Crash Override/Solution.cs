using System;

public partial class Kata
{
    public static string AliasGen(string fName, string lName) {
      if (!Char.IsAsciiLetter(fName[0]) || !Char.IsAsciiLetter(lName[0])) return "Your name must start with a letter from A - Z.";
      return $"{FirstName[Char.ToUpper(fName[0]).ToString()]} {Surname[Char.ToUpper(lName[0]).ToString()]}";
    }
}