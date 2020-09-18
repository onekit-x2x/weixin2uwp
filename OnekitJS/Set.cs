using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Set : Iterable<object> , object{

        int _hashCode = new Random().nextInt();
        override
        public int hashCode()
        {
            return _hashCode;
        }
        java.util.Set<object> _THIS;

        public Set(Array array)
        {
            _THIS = new HashSet(array);
        }

        public Set(string array)
        {
            this(Onekit_JS.string2Array(array));
        }

        public Set()
        {
            _THIS = new HashSet();
        }

        /////////////////////////////////
        public int getSize()
        {
            return _THIS.size();
        }

        public Set Add(object value)
        {
            _THIS.Add(value);
            return this;
        }

        public void clear()
        {
            _THIS.clear();
        }

        public bool delete(object value)
        {
            return _THIS.Remove(value);
        }
        public void forEach(function callback, object THIS)
        {
            callback.thisArg = THIS;
            for (object item : _THIS){
            callback.invoke(item, item, this);
        }
    }
    public void forEach(function callback)
    {
        forEach(callback, null);
    }
    public bool has(object value)
    {
        return _THIS.contains(value);
    }


    override
    public string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.append("Set [");
        int i = 0;
        for (object item : _THIS)
        {
            if (i++ > 0)
            {
                result.append(",");
            }
            result.append(item);
        }
        result.append("]");
        return result.ToString();
    }

    public Iterator values()
    {
        return new Iterator(_THIS.iterator()) {
            override
            public object getValue(Object value)
        {
            return (object)value;
        }

    };
}

override
    public IIterator<object> iterator()
{
    return _THIS.iterator();
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
