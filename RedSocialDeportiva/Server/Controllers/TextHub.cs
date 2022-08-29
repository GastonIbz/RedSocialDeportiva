using Microsoft.AspNetCore.SignalR;

namespace RedSocialDeportiva.Server.Controllers
{
    public class TextHub : Hub
    {
        public async Task Send(string text)
        {
            await Clients.All.SendAsync("ReceiveInformation", text);
        }
    }
}
