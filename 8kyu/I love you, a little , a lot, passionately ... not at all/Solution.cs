using System;

public class Kata
{
  public static string HowMuchILoveYou(int nb_petals)
  {
    switch (nb_petals % 6) {
      case 0:
        return "not at all";
      case 1:
        return "I love you";
      case 2:
        return "a little";
      case 3:
        return "a lot";
      case 4:
        return "passionately";
      case 5:
        return "madly";
      default:
        return "Enter a valid integer";
    }
  }
}