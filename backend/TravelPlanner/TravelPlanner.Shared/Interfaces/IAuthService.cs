using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Remoting;
using TravelPlanner.Shared.DTOs.Auth;

namespace TravelPlanner.Shared.Interfaces;

public interface IAuthService : IService
{
    Task<AuthResponseDto> RegisterAsync(RegisterRequestDto request);

    Task<LoginResponseDto> LoginAsync(LoginRequestDto request);
}
