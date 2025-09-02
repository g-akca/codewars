using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata {
  public static IEnumerable<string> FriendOrFoe (string[] names) {
      return names.Select(n => n)
                  .Where(n => n.Length == 4);
  }
}