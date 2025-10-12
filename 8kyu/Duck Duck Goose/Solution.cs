public class Kata
{
  public static string DuckDuckGoose(Player[] players, int goose) => players[(goose - 1) % players.Length].Name;
}
public class Player 
{
  public string Name {get;set;}
  
  public Player (string name) 
  {
	  this.Name = name;
  }
}