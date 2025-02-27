using System.Text.Json.Serialization;

namespace Api.Responses;
public class Response<T>
{
  private readonly int _code;
  [JsonConstructor]
  public Response() => _code = Configuration.DEFAULT_CODE;

  public Response(
    T? data,
    int code = Configuration.DEFAULT_CODE,
    string? message = null)
  {
    Data = data;
    Message = message;
    _code = code;
  }
  public T? Data { get; set; }
  public string? Message { get; set; }

  [JsonIgnore]
  public bool IsSuccess => _code is >= 200 and <= 299;
}
