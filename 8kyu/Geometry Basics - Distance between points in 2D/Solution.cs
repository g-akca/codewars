using System;

public class Kata
{
  public static double DistanceBetweenPoints(Point a, Point b) => Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
}