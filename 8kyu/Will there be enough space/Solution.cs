using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait) => cap - on < wait ? wait - cap + on : 0;
}