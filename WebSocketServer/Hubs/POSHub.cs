using Microsoft.AspNetCore.SignalR;
using WebSocketServer.Models;

namespace WebSocketServer.Hubs
{
    public class POSHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            var role = Context.GetHttpContext().Request.Headers["Role"];
            if (role == "Cocina")
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, "Pendientes");
            }
            else if (role == "Cajero" || role == "Barra")
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, "Terminadas");
            }

            await base.OnConnectedAsync();
        }

        public async Task SendOrder(OrderHeader order, string role)
        {
            if (role == "Cocina")
            {
                order.HeaderMemo1 = "Terminada";
                await Clients.Group("Terminadas").SendAsync("ReceiveOrder", order);
            }
            else if (role == "Cajero" || role == "Barra")
            {
                order.HeaderMemo1 = "Pendiente";
                await Clients.Group("Pendientes").SendAsync("ReceiveOrder", order);
            }
        }

        //public async Task SendMessage(string user, string Message)
        //{
        //    await Clients.All.SendAsync("ReceiveMessage", user, Message);
        //}
    }
}
