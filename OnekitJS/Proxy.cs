using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Proxy 
    {
    public static Dict apply(string target, Dict thisArg, Dict argumentsList)
    {
        return null;
    }
    public static Dict construct(Dict target, Dict argumentsList, string newTarget)
    {
        return null;
    }
    public static bool defineProperty(Dict target, string property, string descriptor)
    {
        return true;
    }
    public static bool deleteProperty(Dict target, string property)
    {
        return true;
    }
    public static Dict get(Dict target, string property, Dict receiver)
    {
        return null;
    }
    public static Dict getOwnPropertyDescriptor(Dict target, string prop)
    {
        return null;
    }
    public static Dict getPrototypeOf(Dict target)
    {
        return null;
    }
    public static bool has(Dict target, string prop)
    {
        return true;
    }
    public static bool isExtensible(Dict target)
    {
        return true;
    }
    public static Dict ownKeys(Dict target)
    {
        return null;
    }
    public static bool preventExtensions(Dict target)
    {
        return true;
    }
    public static bool set(Dict target, string property, Dict value, Dict receiver)
    {
        return true;
    }
    public static bool setPrototypeOf(Dict target, Dict prototype)
    {
        return true;
    }

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
    }

    override
    public object invoke(params object[] objs)
    {
        return null;
    }
}

}
