using System.Collections.Generic;

namespace BdEntityFramework.Models
{
  public class Teacher : Entity
  {
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public List<Subject> Subjects { get; set; }
  }
}