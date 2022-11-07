using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using System.Text;
namespace ChatAsp
{
    public class ChatHub : Hub
    {
        public async Task GetDataFromClient(string text)
        {
            await Task.Yield();
            throw new System.Exception(text);
        }
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("GetImage", await System.IO.File.ReadAllBytesAsync("C:\\solidcolorbrushes.png"));
            await base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
