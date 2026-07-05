using BackendSF.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendSF.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TravelController : ControllerBase
{
    private readonly TravelProxyService _travelProxy;

    public TravelController(TravelProxyService travelProxy)
    {
        _travelProxy = travelProxy;
    }

    [HttpGet("ping")]
    public async Task<IActionResult> Ping()
    {
        var result = await _travelProxy.PingAsync();
        return Ok(result);
    }
}