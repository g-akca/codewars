public class Counter {
    public static int countSheeps(Boolean[] arrayOfSheeps) {
      int sum = 0;
      for (var bool : arrayOfSheeps) {
        if (bool != null && bool) sum++;
      }
      return sum;
    }
}