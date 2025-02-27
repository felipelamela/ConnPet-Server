namespace Api.Models;

public class ModelBase
{
  public long Id { get; set; }
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; } = DateTime.Now;
}