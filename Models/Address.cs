namespace Api.Models;

public class Address : ModelBase
{
  public int Number { get; set; }
  public string? Complement { get; set; }
  public string Neighborhood { get; set; } = string.Empty;
  public string Street { get; set; } = string.Empty;
  public string City { get; set; } = string.Empty;
  public string State { get; set; } = string.Empty;
  public string PostalCode { get; set; } = string.Empty;
  public string Country { get; set; } = string.Empty;

  public ICollection<Tutor> Tutors { get; set; } = new List<Tutor>();
  public ICollection<User> Users { get; set; } = new List<User>();
  public ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();
}
