using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace java
{
    public static class Class_
    {
        public static FieldInfo getField(this Type THIS,string name)
        {
            return THIS.GetField(name);
        }
        public static FieldInfo getDeclaredField(this Type THIS, string name)
        {
            return THIS.GetField(name);
        }
    }
}
