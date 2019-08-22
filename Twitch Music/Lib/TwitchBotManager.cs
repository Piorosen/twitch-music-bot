using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Api;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace Twitch_Music.Bot
{
    public class TwitchBotManager
    {
        TwitchClient client;
        ListView list;
        TwitchAPI api;

        public TwitchBotManager(string id, string token, ListView listview)
        {
            list = listview;
            list.Items.Clear();

            api = new TwitchAPI();

            api.Settings.ClientId = "dsjhu605wo05ac5e1e74o6m56tokvt";
            api.Settings.AccessToken = "pabilj84ku8hyotjmvjprt39825n8i";

            // pabilj84ku8hyotjmvjprt39825n8i
            ConnectionCredentials credentials = new ConnectionCredentials("KawaiChaCha", "pabilj84ku8hyotjmvjprt39825n8i");
            client = new TwitchClient();
            
            client.Initialize(credentials, "aoikazto");

            client.OnLog += Client_OnLog;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnConnected += Client_OnConnected;

            client.Connect();
            
        }

        private void Client_OnConnected(object sender, TwitchLib.Client.Events.OnConnectedArgs e)
        {
            list.Invoke(new MethodInvoker(() =>
            {
                list.Items.Add("Connected : " + e.AutoJoinChannel + " : " + e.BotUsername);
            }));
        }

        private void Client_OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            list.Invoke(new MethodInvoker(() =>
            {
                list.Items.Add("OnMessageReceived : " + e.ChatMessage.Message);
                
            }));
        }

        private void Client_OnLog(object sender, TwitchLib.Client.Events.OnLogArgs e)
        {
            list.Invoke(new MethodInvoker(() =>
            {
                list.Items.Add("OnLog : " + e.BotUsername + " : " + e.Data + " : " + e.DateTime);

            }));

            }
    }
}
