namespace Api.Models;

public class Clinic : ModelBase
{
  public string CorporateName { get; set; } = string.Empty;
  public string TradingName { get; set; } = string.Empty;
  public string CNPJ { get; set; } = string.Empty;
  public string StateRegistration { get; set; } = string.Empty;
  public string MunicipalRegistration { get; set; } = string.Empty;
  public string Contact { get; set; } = string.Empty;
  public string Email { get; set; } = string.Empty;
  public string DigitalCertification { get; set; } = string.Empty;
  public string Document { get; set; } = string.Empty;

  public long UserAdminId { get; set; }
  public User UserAdmin { get; set; } = null!;

  public long AddressId { get; set; }
  public Address Address { get; set; } = null!;

  public ICollection<User> Users { get; set; } = new List<User>();
  public ICollection<Consultation> Consultations { get; set; } = new List<Consultation>(); // Relacionamento com Consultations

}
