using Api.Models;

namespace Api.models;

public class LoginAuth : ModelBase
{
  public string Login { get; set; } = string.Empty;
  public string Password { get; set; } = string.Empty;

}