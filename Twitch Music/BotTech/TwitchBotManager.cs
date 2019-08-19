using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace Twitch_Music.Bot
{
    public class TwitchBotManager
    {
        TwitchClient client;
        public TwitchBotManager(string id, string token)
        {
            ConnectionCredentials credentials = new ConnectionCredentials(id, token);
            client = new TwitchClient();
            client.Initialize(credentials);

            client.OnLog +=

        }

    }
}
