using Api.models;

namespace Api.Models;

public class User : ModelBase
{
  public string Name { get; set; } = string.Empty;
  public string Document { get; set; } = string.Empty;
  public string CRMV { get; set; } = string.Empty;
  public string StatusWorker { get; set; } = string.Empty;
  public string Type { get; set; } = string.Empty;

  public long LoginAuthId { get; set; }
  public LoginAuth LoginAuth { get; set; } = null!;
  public long AddressId { get; set; }
  public Address Address { get; set; } = null!;
  public long ClinicId { get; set; }
  public Clinic Clinic { get; set; } = null!;
}