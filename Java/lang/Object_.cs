using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java
{
    public static class Object_
    {
        public static int hashCode(this object THIS)
        {
            return THIS.GetHashCode();
        }
        public static Type getClass(this object THIS)
        {
            return THIS.GetType();
        }
        public static string toString(this object THIS)
        {
            return THIS.ToString();
        }
        public static bool equals(this object THIS, object obj)
        {
            return THIS.Equals(obj);
        }
    }
}
