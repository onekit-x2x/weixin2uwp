using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Dict : Dictionary<string,Object>
    {
        int _hashCode = new Random().Next();
        override
    public int hashCode()
        {
            return _hashCode;
        }

        ////////////////////////////


        public static Dict assign(Dict target, Dict...source)
        {
            for (Dict dict : source)
            {
                for (Dict.Entry<string, object> entry : dict.entrySet())
                {
                    target.put(entry.getKey(), entry.getValue());
                }
            }
            return target;
        }
        public static Dict create(Dict target, Dict propertiesObject)
        {
            Dict result = new Dict();
            for (Entry<string, object> entry : target.entrySet())
            {
                result.put(entry.getKey(), entry.getValue());
            }
            return result;
        }
        public static Dict create(Dict target)
        {
            return create(target, null);
        }

        public static void defineProperties(Dict obj, Dict props)
        {
        }
        public static Iterator entries(Dict obj)
        {
            return new Iterator(obj.entrySet().iterator()){

            override
            public Array getValue(Object value)
            {
                Entry<string, object> entry = (Entry)value;
                return new Array() { { Add(new string(entry.getKey())); Add(entry.getValue());
            }
        };
    }
};
    }

    public static Array keys(Dict dict)
{
    Array result = new Array();
    for (string key: dict.keySet() ) {
    result.Add(new string(key));
}
return result;
    }
    public static Array keys(Array array)
{
    Array result = new Array();
    for (int i = 0; i < array.size(); i++)
    {
        object item = array.get(i);
        if (item == null)
        {
            continue;
        }
        result.Add(new string(string.valueOf(i)));
    }
    return result;
}


override
    public string ToString()
{
    StringBuilder result = new StringBuilder();
    result.append("{");
    string[] keys = this.keySet().toArray(new string[] { });
    for (int i = 0; i < keys.length; i++)
    {
        string key = keys[i];
        if (i > 0)
        {
            result.append(",");
        }
        result.append(string.Format("\"%s\":%s", key, Onekit_JS.ToString(this.get(key))));
    }
    result.append("}");
    return result.ToString();
}
public string toLocaleString(object locales, object options)
{
    return new string("");
}
override
    public object get(string key)
{
    return super.get(key);
}
override
    public object get(object key)
{
    return get(((string)key).THIS);
}

override
    public void set(string key, object value)
{
    put(key, value);
}

override
    public void set(object key, object value)
{
    put(key.ToString(), value);
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
