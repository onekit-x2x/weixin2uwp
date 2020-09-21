using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace java.lang
{
    public class Class
    {
        private Type type;

        public Class(Type type)
        {
            this.type = type;
        }

        public  FieldInfo getField( string name)
        {
            return type.GetField(name);
        }
        public FieldInfo getDeclaredField(string name)
        {
            return type.GetField(name);
        }
    }
}
