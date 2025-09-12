public class RentalCar {
    
    public static int RentalCarCost(int d) {
      if (d >= 7) return 40 * d - 50;
      else if (d >= 3) return 40 * d - 20;
      return 40 * d;
    }
}