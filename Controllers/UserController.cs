using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("v1/user")]
public class UsersController : ControllerBase
{

  [HttpGet]
  public async Task<IResult> GetUsers()
  {
    return TypedResults.Ok();
  }

  [HttpGet("{id}")]
  public async Task<IResult> GetUser(int id)
  {
    return TypedResults.Ok();
  }

  [HttpPost]
  public ActionResult AddUser([FromBody] string name)
  {
    return Ok(new { message = "Usuário adicionado!", name });
  }

  [HttpDelete("{id}")]
  public ActionResult RemoveUser(int id)
  {
    return Ok(new { message = "Usuário removido!" });
  }
}
