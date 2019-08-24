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
        MusicQueue MusicQueue = new MusicQueue();

        event EventHandler<MusicQueue> ChangedMusicQueue;
        event EventHandler<YoutubeMusic> NextMusicQueue;

        public TwitchBotManager(string channel)
        {
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
            var message = e.ChatMessage.Message;
            
            if (message[0] == '!')
            {
                if (message.Contains("추가") == true)
                {
                    MusicQueue.Add(message.Split()[1]);
                    ChangedMusicQueue?.Invoke(this, MusicQueue);
                }
                else if (message.Contains("다음"))
                {
                    
                    NextMusicQueue?.Invoke(this, MusicQueue.Next());
                }

            }


        }
    }
}
