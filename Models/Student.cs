namespace BdEntityFramework.Models
{
  public class Student : Entity
  {
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public Instrument Instrument { get; set; }
  }
}