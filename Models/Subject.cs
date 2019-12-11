using System;

namespace BdEntityFramework.Models
{
  public class Subject : Entity
  {
    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
  }   
}