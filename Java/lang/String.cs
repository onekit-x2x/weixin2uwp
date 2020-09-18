using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java
{
    public class String
    {
        public static string format(string format, params object[] objs)
        {
            return string.Format(format, objs);
        }
        public static string valueOf(object value)
        {
            return string.Format("{0}", value);
        }
    }
}
