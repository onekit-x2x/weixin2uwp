using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace java.lang.reflect
{
    public static class Field_
    {
        public static object get(this FieldInfo THIS,object target)
        {
            return THIS.GetValue(target);
        }
        public static void set(this FieldInfo THIS, object target,object value)
        {
             THIS.SetValue(target,value);
        }
    }
}
