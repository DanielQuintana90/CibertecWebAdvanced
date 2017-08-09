using Microsoft.AspNet.SignalR;

namespace Cibertec.RealTime.Hubs
{
    public class NotificacionHub : Hub
    {
        public void UpdateProduct(int id)
        {
            Clients.All.updateProduct(id);
        }
    }
}