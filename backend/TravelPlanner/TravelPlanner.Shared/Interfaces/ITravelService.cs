using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.ServiceFabric.Services.Remoting;
using System.Threading.Tasks;


namespace TravelPlanner.Shared.Interfaces;

public interface ITravelService : IService
{
    Task<string> PingAsync();
}