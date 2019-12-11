namespace BdEntityFramework.Models
{
  public class Instrument: Entity
  {
    public int Name { get; set; }
    public double Price { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
  }
}