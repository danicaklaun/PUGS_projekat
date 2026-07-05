using Microsoft.ServiceFabric.Services.Remoting.Client;
using TravelPlanner.Shared.Interfaces;

namespace BackendSF.Services;

public class TravelProxyService
{
    private readonly ITravelService _travelService;

    public TravelProxyService()
    {
        _travelService = ServiceProxy.Create<ITravelService>(
            new Uri("fabric:/TravelPlanner/TravelService"));
    }

    public ITravelService Service => _travelService;
}