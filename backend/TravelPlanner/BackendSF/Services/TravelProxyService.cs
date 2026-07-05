using Microsoft.ServiceFabric.Services.Remoting.Client;
using TravelPlanner.Shared.Interfaces;
using Microsoft.ServiceFabric.Services.Client;

namespace BackendSF.Services;



public class TravelProxyService
{
    private readonly ITravelService _travelService;

    public TravelProxyService()
    {
        _travelService = ServiceProxy.Create<ITravelService>(
     new Uri("fabric:/TravelPlanner/TravelService"),
     new ServicePartitionKey(0));
    }

    public Task<string> PingAsync()
    {
        return _travelService.PingAsync();
    }
}