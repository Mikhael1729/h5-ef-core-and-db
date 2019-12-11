using System.Collections.Generic;

namespace BdEntityFramework.Models
{
  public class Teacher : Entity
  {
    public string Name { get; set; }
    public string FirstName { get; set; }
    public List<Subject> Subjects { get; set; }
  }
}