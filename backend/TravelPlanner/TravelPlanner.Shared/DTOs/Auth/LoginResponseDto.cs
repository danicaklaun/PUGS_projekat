using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner.Shared.DTOs.Auth;

public class LoginResponseDto
{
    public bool Success { get; set; }

    public string Token { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;
}