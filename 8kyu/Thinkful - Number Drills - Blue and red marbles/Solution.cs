public static class BlueAndRedMarbles {
    public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled) => (double)(blueStart - bluePulled) / (blueStart - bluePulled + redStart - redPulled);
}