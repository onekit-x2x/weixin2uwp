using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using thekit;

namespace cn.onekit.js.core
{
    public class function:object
    {
        object obj;
        MethodInfo method;
        public object thisArg;
        public function()
        {

        }

        public function(Type clazz, string methodName,params Type[] types)
        {
            try
            {
                method = clazz.GetMethod(methodName, types);
            }
            catch (NotSupportedException e)
            {
                e.printStackTrace();
            }
        }

        public function(object obj, string methodName, params Type[] types) :
            this(obj.GetType(), methodName, types)
        {
            this.obj = obj;
        }
        public object invoke(params object[] arguments)
        {
            try
            {
                return (object)method.Invoke(obj, arguments);
            }
            catch (Exception e)
            {
                e.printStackTrace();
                return null;
            }
        }
        /*
        override
     public object get(string key)
        {
            return null;
        }

        override
     public object get(object key)
        {
            return null;
        }

        override
     public void set(string key, object value)
        {

        }

        override
     public void set(object key, object value)
        {

        }

        override
     public string ToString()
        {
            return null;
        }

        override
     public string toLocaleString(string locales, object options)
        {
            return null;
        }*/
    }
}
