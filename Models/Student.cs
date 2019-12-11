namespace BdEntityFramework.Models
{
  public class Student : Entity
  {
    public string Name { get; set; }
    public string LastName { get; set; }
    public Instrument Instrument { get; set; }
  }
}