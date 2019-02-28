using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterStreaming.Hubs
{
    public class TweetHub: Hub
    {
        public async Task FilterTweets( string filter)
        {
            await Clients.All.SendAsync("FilterPageTweets",filter);
        }
    }
}
