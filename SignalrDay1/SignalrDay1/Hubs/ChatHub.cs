using Microsoft.AspNetCore.SignalR;
namespace SignalrDay1.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMsg(string name, string msg)
        {
            // save msg in db

            // send new msg to all online clients
            Clients.All.SendAsync("newmessage", name, msg);
        }

    }
}
