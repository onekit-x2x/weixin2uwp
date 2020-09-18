using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java.lang
{
    public static class StringBuilder_
    {
        public static void append(this StringBuilder THIS,string str)
        {
            THIS.Append(str);
        }
        public static int length(this StringBuilder THIS)
        {
            return THIS.Length;
        }
    }
}
