using System.Collections.Generic;

namespace BdEntityFramework.Models
{
  public class Classroom
  {
    public int Id { get; set; }
    public List<Subject> Subjects { get; set; }
  }
}