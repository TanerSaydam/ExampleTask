using ExampleTask.Application.Features.Auth.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ExampleTask.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Login(LoginCommand request, CancellationToken cancellationToken )
    {
        var response = await mediator.Send(request, cancellationToken);
        return Ok(new {Messages = response });
    }
}
