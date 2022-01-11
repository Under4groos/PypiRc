using PrLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrRypi
{
    internal class Program
    {
        PrLib.VersionPython versionPython = new PrLib.VersionPython();
        static void Main(string[] args)
        {
            //HtmlDownload html = new HtmlDownload()
            //{
            //    Url = "https://pypi.org/project/pip/"
            //};
            //html.Download();
            //html.Save("test.html");
            //Console.WriteLine(html.Content);

            // <a href="https://www.python.org/ftp/python/3.10.1/python-3.10.1-macos11.pkg">macOS 64-bit universal2 installer</a>


            //foreach (var item in versionPython.versions)
            //{
            //    Console.WriteLine(item.url_downloads);
            //}

            // python_org_url.isDownloadsRelease("https://www.python.org/downloads/release/python-387/")
            // Console.WriteLine();

            //DPython dPython = new DPython("https://www.python.org/downloads/release/python-3101/");
            //foreach (var item in dPython.pyrelease_Vers)
            //{
            //    Console.WriteLine(item);
            //}

            //<a href="https://www.python.org/ftp/python/3.10.1/python-3.10.1-amd64.exe">Windows installer (64-bit)</a>
            Console.WriteLine(python_org_url.isValidUrlDownFileRelease32("https://www.python.org/ftp/python/3.10.1/python-3.10.1-amd64.exe"));

            Console.ReadLine();
        }
    }
}
