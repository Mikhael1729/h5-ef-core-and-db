namespace BdEntityFramework.Models
{
  public class Instrument
  {
    public int Id { get; set; }
    public int Name { get; set; }
    public double Price { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
  }
}