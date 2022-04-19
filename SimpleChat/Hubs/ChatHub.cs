using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNetCore.SignalR;
using HubMethodNameAttribute = Microsoft.AspNet.SignalR.Hubs.HubMethodNameAttribute;

namespace SimpleChat.Hubs
{

    [HubName("chathub")]
    public class ChatHub:Hub
    {

        [HubMethodName("sendmassage")]
        public void SendMassage(string name, string msg)
        {

            Clients.All.SendAsync("sendmsg", name, msg);
        }

    }
}
