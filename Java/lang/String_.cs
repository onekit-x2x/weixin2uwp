using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java
{
    public static class String_
    {
        public static int length(this string THIS)
        {
            return THIS.Length;
        }
        public static char[] toCharArray(this  string THIS)
        {
            return THIS.ToCharArray();
        }
        public static bool startsWith(this string THIS, string str)
        {
            return THIS.StartsWith(str);
        }
        public static bool endsWith(this string THIS, string str)
        {
            return THIS.EndsWith(str);
        }
        public static string substring(this string THIS,int start)
        {
            return THIS.Substring(start);
        }
        public static string substring(this string THIS, int start,int end)
        {
            return THIS.Substring(start,end-start);
        }
        public static int indexOf(this string THIS, string str)
        {
            return THIS.indexOf(str);
        }
        public static int lastIndexOf(this string THIS,string str)
        {
            return THIS.LastIndexOf(str);
        }
        public static string[] split(this string THIS, string str)
        {
            return THIS.Split(str);
        }
        public static string toLowerCase(this string THIS)
        {
            return THIS.ToLower();
        }
        public static string toUpperCase(this string THIS)
        {
            return THIS.ToUpper();
        }
        public static string trim(this string THIS)
        {
            return THIS.Trim();
        }
        public static string replace(this string THIS,string str1,string str2)
        {
            int p = THIS.IndexOf(str1);
            if (p < 0)
            {
                return THIS;
            }
            return string.Format("{0}{1}", THIS.Substring(0, p), THIS.Substring(p + str1.Length));
        }
        public static string replaceAll(this string THIS, string str1, string str2)
        {
            return THIS.Replace(str1, str2);
        }
        public static bool contains(this string THIS, string str)
        {
            return THIS.Contains(str);
        }
    }
}
