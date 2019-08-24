using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Twitch_Music.Library;

namespace Twitch_Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        TwitchBotManager bot;

        private void Bot_NextMusicQueue(object sender, YoutubeMusic e)
        {
            webBrowser1.Navigate(e.Link);
        }

        private void Bot_ChangedMusicQueue(object sender, MusicQueue e)
        {
            listMusicLink.Clear();
            listMusicTitle.Clear();

            foreach (var p in e.List)
            {
                listMusicLink.Items.Add(p.Link);
                listMusicTitle.Items.Add(p.Title);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bot.TestCommand(Text_Command.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bot = new TwitchBotManager(Text_Channel.Text);
            bot.ChangedMusicQueue += Bot_ChangedMusicQueue;
            bot.NextMusicQueue += Bot_NextMusicQueue;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            bot.Delete();
        }
    }
}
