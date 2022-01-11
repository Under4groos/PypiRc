using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrLib
{
    public struct pyrelease_ver
    {
        public string url_dow { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return $"{url_dow} | {name}";
        }
    }
    public class DPython
    {
        //https://www.python.org/downloads/release/python-387/
        // <a href="https://www.python.org/ftp/python/3.8.7/python-3.8.7.exe">Windows installer (32-bit)</a>
        public List<pyrelease_ver> pyrelease_Vers = new List<pyrelease_ver>();


        public DPython(string url)
        {
            if (!python_org_url.isDownloadsRelease(url))
            {
                throw new Exception("isDownloadsRelease = false");
            }

            HtmlDownload htmlDownload = new HtmlDownload();
            htmlDownload.Url = url;
            htmlDownload.Download();
            htmlDownload.Save("dd.html");


            

            // <a href="https://www.python.org/ftp/python/3.10.1/python-3.10.1.exe">Windows installer (32-bit)</a>
            // <a href="https://www.python.org/ftp/python/3.10.1/python-3.10.1-amd64.exe">Windows installer (64-bit)</a>

            foreach (var pattern_ in new string[] { python_org_url.pattern_32_bit, python_org_url.pattern_64_bit })
            {
                MatchCollection mc_ = Regex.Matches(htmlDownload.Content, pattern_);
                foreach (Match m in mc_)
                {

                    string[] srt_ar = m.Value.Replace("\">", ",").Split(',');
                    pyrelease_ver pyrelease_Ver = new pyrelease_ver()
                    {
                        url_dow = srt_ar[0],
                        name = srt_ar[1],
                    };

                    pyrelease_Vers.Add(pyrelease_Ver);
                }
            }


        }

    }
}
