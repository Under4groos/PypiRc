using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrLib
{
    public class DownloadFile
    {
        public DownloadFile(string url)
        {

           

            using (WebClient client = new WebClient())
            {
                 
                //client.DownloadFile("http://example.com/file/song/a.mpeg", "a.mpeg");
            }
        }
    }
}
