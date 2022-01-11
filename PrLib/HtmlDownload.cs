using System;
using System.IO;
using System.Net;

namespace PrLib
{
    internal class HtmlDownload
    {
        public string Url { get; set; }
        public string Content { get; set; }
        public void Download()
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadProgressChanged += (o, e) =>
                {
                    Console.WriteLine(e.ProgressPercentage.ToString());
                };

                Content = client.DownloadString(Url);
            }
        }
        public void Save(string path)
        {
            File.WriteAllText(path, Content);
        }

    }
}
