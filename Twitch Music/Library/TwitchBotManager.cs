using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Api;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace Twitch_Music.Library
{
    public class TwitchBotManager
    {
        TwitchClient client;
        ListView list;

        public TwitchBotManager(string channel, ListView listview)
        {
            list = listview;
            list.Items.Clear();

            // api.Settings.ClientId = "dsjhu605wo05ac5e1e74o6m56tokvt";
            // api.Settings.AccessToken = "pabilj84ku8hyotjmvjprt39825n8i";

            // pabilj84ku8hyotjmvjprt39825n8i
            ConnectionCredentials credentials = new ConnectionCredentials("KawaiChaCha", "pabilj84ku8hyotjmvjprt39825n8i");
            client = new TwitchClient();
            
            client.Initialize(credentials, channel);

            client.OnMessageReceived += Client_OnMessageReceived;

            client.Connect();
            
        }
        private void Client_OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
        }
    }
}
