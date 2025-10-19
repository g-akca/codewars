using System;

public class Ghost
{
  private static string[] colors = {"white", "yellow", "purple", "red"};
  private string color;
  
  public Ghost() {
    var rand = new Random();
    this.color = colors[rand.Next(4)];
  }
  
  public string GetColor() {
    return this.color;
  }
}