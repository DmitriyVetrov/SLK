using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Slk.Models;
using Microsoft.AspNet.Identity;

namespace Slk.Web.Hubs
{
    public class BusinessHub : Hub
    {
        static List<User> _users = new List<User>();

        public static IList<string> GetConnectionIdsByName(string name)
        {
            return _users.Where(w => w.Name == name).Select(s => s.ConnectionId).ToList();
        }

        [Authorize]
        public override Task OnConnected()
        {
            //if (Context.User == null) return base.OnConnected();

            var idn = Context.User.Identity;
            if (idn.IsAuthenticated)
            {
                var user = new User { Id = idn.GetUserId<int>(), ConnectionId = Context.ConnectionId };
                if (!_users.Any(x => x.Id == user.Id && x.ConnectionId == user.ConnectionId))
                    _users.Add(user);

                Clients.All.onConnected(user.ConnectionId, user.ToString(), _users);
            }

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            var idn = Context.User.Identity;
            if (idn.IsAuthenticated)
            {
                var item = _users.FirstOrDefault(x => x.Id == idn.GetUserId<int>());
                if (item != null)
                {
                    _users.Remove(item);
                    Clients.All.onUserDisconnected(_users);
                }
            }

            return base.OnDisconnected(stopCalled);
        }
    }
}