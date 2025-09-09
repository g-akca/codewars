public class Hero {
  public string Name;
  public string Position = "00";
  public float Health = 100;
  public float Damage = 5;
  public int Experience = 0;
  
  public Hero(string name = "Hero") {
    this.Name = name;
  }
}