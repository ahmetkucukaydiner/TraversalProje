using Microsoft.AspNetCore.SignalR;
using Traversal.SignalRApiForMSSql.Model;

namespace Traversal.SignalRApiForMSSql.Hubs
{
    public class VisitorHub : Hub
    {
        private readonly VisitorService _visitorService;

        public VisitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("CallVisitList", _visitorService.GetVisitorChartList());
        }
    }
}
