using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Map 
    {


    private java.util.Map<object, object> _THIS = new HashMap<>();

    public int getSize()
    {
        return _THIS.size();
    }

    /////////////////////////////
    public void clear()
    {
        _THIS.clear();
    }

    public bool delete(object key)
    {
        for (Dict.Entry<object, object> entry :_THIS.entrySet())
        {
            if (entry.getKey().hashCode() == key.hashCode())
            {
                _THIS.Remove(entry.getKey());
                return true;
            }
        }
        return false;
    }

    public Iterator entries()
    {
        return new Iterator(_THIS.entrySet().iterator()){

            override
            public Object getValue(Object value)
        {
            Dict.Entry<object, object> entry = (Dict.Entry)value;
            return new Array() { { Add(entry.getKey()); Add(entry.getValue());
        }
    };
}
        };
    }

    public void forEach(function callback, object thisArg)
{
    callback.thisArg = thisArg;
    for (Dict.Entry<object, object> entry : _THIS.entrySet()) {
    callback.invoke(entry.getValue(), entry.getKey(), this);
}
    }
    public void forEach(function callback)
{
    forEach(callback, null);
}

override
    public object get(string key)
{
    return null;
}

public object get(object key)
{
    return _THIS.get(key);
}

override
    public void set(string key, object value)
{

}

public JsBoolean has(object key)
{
    for (Dict.Entry entry :_THIS.entrySet()){
    if (entry.getKey().hashCode() == key.hashCode())
    {
        return new JsBoolean(true);
    }
}
return new JsBoolean(false);
    }

    public Iterator keys()
{
    return new Iterator<object>(_THIS.entrySet().iterator()) {

            override
            public object getValue(Object value)
    {
        Dict.Entry<object, object> entry = (Dict.Entry<object, object>)value;
        return entry.getKey();
    }
};
    }

    public void set(object key, object value)
{
    _THIS.put(key, value);
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

public Iterator values()
{
    return new Iterator(_THIS.entrySet().iterator()) {


            override
            public object getValue(Object value)
    {
        Dict.Entry<object, object> entry = (Dict.Entry<object, object>)value;
        return entry.getValue();
    }
};
    }

}

}
