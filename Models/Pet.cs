namespace Api.Models;

public class Pet : ModelBase
{
  public string Name { get; set; } = string.Empty;
  public DateTime BirthDate { get; set; }
  public string Species { get; set; } = string.Empty;
  public string Breed { get; set; } = string.Empty;
  public string Sex { get; set; } = string.Empty;

  public long TutorId { get; set; }
  public Tutor Tutor { get; set; } = null!;
}
