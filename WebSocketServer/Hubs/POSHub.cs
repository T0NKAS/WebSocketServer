using Microsoft.AspNetCore.SignalR;

namespace WebSocketServer.Hubs
{
    public class POSHub : Hub
    {
        public async Task SendMessage(string user, string Message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, Message);
        }
    }
}
