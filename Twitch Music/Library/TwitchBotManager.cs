using System;
using System.Collections.Generic;
using System.Drawing;
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

        private string channel;

        public event EventHandler<MusicQueue> ChangedMusicQueue;
        public event EventHandler<YoutubeMusic> NextMusicQueue;
        public event EventHandler StopMusicQueue;

        public TwitchBotManager(string channel)
        {
            this.channel = channel;

            // api.Settings.ClientId = "dsjhu605wo05ac5e1e74o6m56tokvt";
            // api.Settings.AccessToken = "pabilj84ku8hyotjmvjprt39825n8i";
            // pabilj84ku8hyotjmvjprt39825n8i

            ConnectionCredentials credentials = new ConnectionCredentials("KawaiChaCha", "pabilj84ku8hyotjmvjprt39825n8i");
            client = new TwitchClient();
            
            client.Initialize(credentials, channel);

            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnJoinedChannel += Client_OnJoinedChannel;
            client.Connect();
            
        }

        private void Client_OnJoinedChannel(object sender, TwitchLib.Client.Events.OnJoinedChannelArgs e)
        {
            client.SendMessage(channel, "차차가 입장했어요~");
        }

        public void TestCommand(string command)
        {
            Client_OnMessageReceived(this, new TwitchLib.Client.Events.OnMessageReceivedArgs()
            {
                ChatMessage = new ChatMessage("", "", "", "", "", Color.White, new EmoteSet("", ""), command, TwitchLib.Client.Enums.UserType.Admin, "", "", false, 0, "", false, false, false, false, TwitchLib.Client.Enums.Noisy.False, "", "", new List<KeyValuePair<string, string>>(), new CheerBadge(0), 0, 0)

            });
        }

        public void Delete()
        {
            MusicQueue.Delete();
        }

        private void Client_OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            var message = e.ChatMessage.Message;
            
            if (message[0] == '#')
            {
                if (message.Contains("추가") == true)
                {
                    client.SendMessage(channel, $"귀여운 차차가 노래를 추가 했어!! : \t{new Random().NextDouble()}");
                    MusicQueue.Add(message.Split()[1]);
                    ChangedMusicQueue?.Invoke(this, MusicQueue);
                }
                else if (message.Contains("다음"))
                {
                    var p = MusicQueue.Next();

                    client.SendMessage(channel, $"차차가 {p.Title} 노래를 재생하기 시작했어! : \t{new Random().NextDouble()}");
                    NextMusicQueue?.Invoke(this, p);
                    ChangedMusicQueue?.Invoke(this, MusicQueue);
                }
                else if (message.Contains("중지"))
                {
                    StopMusicQueue?.Invoke(this, null);
                }
                else
                {
                    client.SendMessage(channel, $"차차가 알아 듣지 못하는 명령어를 받아 버렸어..! : \t{new Random().NextDouble()}");
                }
            }
        }

    }
}
