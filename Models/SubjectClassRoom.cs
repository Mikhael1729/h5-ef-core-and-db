namespace BdEntityFramework.Models
{
  public class SubjectClassroom
  {
    public int Id { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }
    public int ClassroomId { get; set; }
    public Classroom Classroom { get; set; }
    
  }
}