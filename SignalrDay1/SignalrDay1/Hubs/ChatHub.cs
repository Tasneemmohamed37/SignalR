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

        public void joinGroup(string groupName, string name)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            // notify group members
            Clients.Group(groupName).SendAsync("newmember", name, groupName);
        }

        public void SendToGroup(string groupName, string name, string msg)
        {
            Clients.Group(groupName).SendAsync("newMessageGroup", name, groupName, msg);
        }

    }
}
