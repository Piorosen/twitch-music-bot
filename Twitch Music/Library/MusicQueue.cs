﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitch_Music.Library
{
    public class YoutubeMusic
    {
        public string Title;
        public double Length;
        public string Link;
    }
    public class MusicQueue
    {
        Queue<YoutubeMusic> musicQueue = new Queue<YoutubeMusic>();

        public MusicQueue()
        {
        }

        string GetTitle(string Link)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;

            var p = client.DownloadString($"{Link}");
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(p);

            var metas = doc.DocumentNode.SelectNodes("//meta");

            string result = "";

            if (metas != null)
            {
                foreach (var tag in metas)
                {
                    var tagName = tag.Attributes["name"];
                    var tagContent = tag.Attributes["content"];
                    if (tagName != null && tagContent != null)
                    {
                        switch (tagName.Value.ToLower())
                        {
                            case "title":
                                result = tagContent.Value;
                                break;
                            case "twitter:title":
                                result = string.IsNullOrEmpty(result) ? tagContent.Value : result;
                                break;
                        }
                    }
                }
            }

            return result;
        }

        int GetDuration(string Link)
        {
            return 240;
        }

        public void Add(string Link)
        {
            musicQueue.Enqueue(new YoutubeMusic
            {
                Title = GetTitle(Link),
                Link = Link,
                Length = GetDuration(Link)
            });
        }

        public YoutubeMusic Next()
        {
            if (musicQueue.Count != 0)
            {
                return musicQueue.Dequeue();
            }
            else
            {
                return new YoutubeMusic();
            }
            
        }

        public void Delete()
        {
            musicQueue.Dequeue();
        }

        public int Count => musicQueue.Count;

        public YoutubeMusic[] List => musicQueue.ToArray();

    }
}
