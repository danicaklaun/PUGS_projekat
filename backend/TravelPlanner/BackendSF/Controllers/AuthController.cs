using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using TravelPlanner.Shared.DTOs.Auth;
using TravelPlanner.Shared.Interfaces;

namespace BackendSF.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequestDto request)
    {
        var proxy = ServiceProxy.Create<IAuthService>(
            new Uri("fabric:/TravelPlanner/AuthService"));

        var result = await proxy.RegisterAsync(request);

        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequestDto request)
    {
        var proxy = ServiceProxy.Create<IAuthService>(
            new Uri("fabric:/TravelPlanner/AuthService"));

        var result = await proxy.LoginAsync(request);

        return Ok(result);
    }
}