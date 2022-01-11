using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrLib
{
    public static class sstring
    {
        public static string mul_Replace(this string str, string[] str_rep , string str_d = "")
        {
            foreach (var item in str_rep)
            {
                str = str.Replace(item,str_d);
            }
            return str;
             
        }
    }
}
