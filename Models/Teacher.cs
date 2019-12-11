using System.Collections.Generic;

namespace BdEntityFramework.Models
{
  public class Teacher
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public List<Subject> Subjects { get; set; }
  }
}