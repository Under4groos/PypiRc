using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrLib
{
    public class Version
    {
        public string Ver { get; set; }
        public string url_downloads { get; set; }

        public override string ToString()
        {
            return $"{Ver} | {url_downloads}";
        }
    }
    public class VersionPython
    {
        public string URL = "https://www.python.org";
        HtmlDownload htmlDownload;
        private List<Version> python_versions_urls = new List<Version>();
        public List<Version> versions
        {
            get { return python_versions_urls; }
        }
        public int Count
        {
            get { return python_versions_urls.Count; }

        }
        public VersionPython()
        {
            htmlDownload = new HtmlDownload()
            {
                Url = "https://www.python.org/downloads/",
            };
            htmlDownload.Download();
            //string pattern = @"https:\/\/docs\.python\.org\/release\/[0-9]+.[0-9]+.[0-9]+\/whatsnew\/changelog\.html#changelog";
            string pattern = "<a href=\"\\/downloads\\/release\\/python\\-[0-9]+\\/\">Python [0-9]+.[0-9]+.[0-9]+";

            MatchCollection mc = Regex.Matches(htmlDownload.Content, pattern);

            foreach (Match match in mc)
            {

                // https://www.python.org/downloads/release/python-201/Python 2.0.1</a>
                 

                string value_ver =$"{Regex.Matches(match.Value, "[0-9]+.[0-9]+.[0-9]+")[0]?.Value ?? ""}";

                //MatchCollection vers_ = Regex.Matches(match.Value, "[0-9]+.[0-9]+.[0-9]+");
                // <a href="/downloads/release/python-3101/">Python 3.10.1</a>
                Version ver_ = new Version()
                {
                    url_downloads = $"{URL}" + match.Value.mul_Replace(
                        new string[]
                        {
                            "<a href=\"", "\">", value_ver , "Python"
                        }
                    ),
                    Ver = value_ver
                };
                python_versions_urls.Add(ver_);
            }
        }

        public override string ToString()
        {
            return string.Join("\n", python_versions_urls);
        }
    }
}
