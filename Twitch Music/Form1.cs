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

        private void Button1_Click(object sender, EventArgs e)
        {
            TwitchBotManager bot = new TwitchBotManager("aoikazto", listMusicLink);
            
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
