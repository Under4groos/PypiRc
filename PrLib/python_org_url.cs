using System.Text.RegularExpressions;

namespace PrLib
{
    public static class python_org_url
    {
        public static string pattern_32_bit = "https:\\/\\/www\\.python\\.org\\/ftp\\/python\\/[0-9]+\\.[0-9]+\\.[0-9]+\\/python\\-[0-9]+\\.[0-9]+[0-9]+\\.[0-9]+\\.exe\">[\\w ]+\\([0-9]+\\-bit\\)";
        public static string pattern_64_bit = "https:\\/\\/www\\.python\\.org\\/ftp\\/python\\/[0-9]+\\.[0-9]+\\.[0-9]+\\/python\\-[0-9]+\\.[0-9]+[0-9]+\\.[0-9]+\\-amd64\\.exe\">[\\w ]+\\([0-9]+\\-bit\\)";

        public static string pattern_32_bit_exe = "https:\\/\\/www\\.python\\.org\\/ftp\\/python\\/[0-9]+\\.[0-9]+\\.[0-9]+\\/python\\-[0-9]+\\.[0-9]+[0-9]+\\.[0-9]+\\.exe";
        public static string pattern_64_bit_exe = "https:\\/\\/www\\.python\\.org\\/ftp\\/python\\/[0-9]+\\.[0-9]+\\.[0-9]+\\/python\\-[0-9]+\\.[0-9]+[0-9]+\\.[0-9]+\\-amd64\\.exe";


        public static bool isValidUrlDownFileRelease32(string url)
        {
            return Regex.Matches(url, pattern_32_bit_exe).Count > 0 ? true : false;
        }
        public static bool isValidUrlDownFileRelease64(string url)
        {
            return Regex.Matches(url, pattern_64_bit_exe).Count > 0 ? true : false;
        }

        public static bool isDownloadsRelease(string url)
        {
            // https://www.python.org/downloads/release/python-387/
            // pattern https:\/\/www\.python\.org\/downloads\/release\/python\-[0-9]+\/

            string pattern_ = @"https:\/\/www\.python\.org\/downloads\/release\/python\-[0-9]+\/";
            return Regex.Matches(url, pattern_).Count > 0 ? true : false;
            // gmod wire E2 , lua , python , C# , c++
        }

    }
}
