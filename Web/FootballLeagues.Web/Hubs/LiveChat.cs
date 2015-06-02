using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace FootballLeagues.Web.Hubs
{
    public static class UserHandler
    {
        public static HashSet<string> ConnectedUsers = new HashSet<string>();
    }
    public class LiveChat : Hub
    {
        public override Task OnConnected()
        {
            UserHandler.ConnectedUsers.Add(Context.User.Identity.Name);
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            UserHandler.ConnectedUsers.Remove(Context.User.Identity.Name);
            return base.OnDisconnected(true);
        }

        public void GetActiveUsers()
        {
            Clients.Caller.renderActiveUsers(UserHandler.ConnectedUsers);
        }

        public void JoinRoom(string room)
        {
            Groups.Add(Context.ConnectionId, room);
            Clients.Caller.joinRoom(room);
        }

        public void LeaveRoom(string room)
        {
            Groups.Remove(Context.ConnectionId, room);
            Clients.Group(room).addInfoMessage(string.Format("--- {0} leave room...--- ", Context.User.Identity.Name), room);
            Clients.Caller.leaveRoom(room);
        }

        public void ChangeRoom(string currentRoom, string newRoom)
        {
            Clients.Group(currentRoom).addInfoMessage(string.Format("--- {0} is AFR...--- ", Context.User.Identity.Name), currentRoom);
            Groups.Add(Context.ConnectionId, newRoom);
            Clients.Group(newRoom).addInfoMessage(string.Format("--- {0} is back/join to room... ---", Context.User.Identity.Name), newRoom);
            Clients.Caller.changeRoom(newRoom);
        }

        public void SendMessageToRoom(string message, string room)
        {
            var msg = string.Format("{0}: {1}", Context.User.Identity.Name, message);
            if (room != "All")
            {
                Clients.Group(room).addMessage(msg, room);
            }
            else
            {
                Clients.All.addMessage(msg, room);
            }

        }
    }
}