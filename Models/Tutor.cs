namespace Api.Models;

public class Tutor : ModelBase
{
  public string Name { get; set; } = string.Empty;
  public string Login { get; set; } = string.Empty;
  public string Password { get; set; } = string.Empty;
  public string Document { get; set; } = string.Empty;

  public long? AddressId { get; set; }
  public Address Address { get; set; } = null!;
  public ICollection<Pet>? Pets { get; set; }
}