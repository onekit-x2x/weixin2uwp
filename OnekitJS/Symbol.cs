using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Symbol 
    {

    static List _Symbols = new ArrayList();
    object _description;
    public Symbol(object description)
    {
        _description = description;
        string result = string.Format("__%s_%d_%d__", description, (int)java.lang.Math.floor(java.lang.Math.random() * 1e9), _Symbols.size() + 1);
        _Symbols.Add(result);
    }
    public Symbol()
    {
        this(new JsNumber(new Random().nextInt()));
    }
    public static bool asyncIterator;
    public static bool hasInstance;
    public static Dict isConcatSpreadable;
    public static Array iterator;
    public static string match;
    public static Dict matchAll;
    public readonly string description = null;
    public static string replace;
    public static Dict search;
    public static bool species;
    public static string split;
    public static Dict toPrimitive;
    public static string toStringTag;
    public static Dict unscopables;
    //////////////////////////////
    public static Dict For(string key)
    {
        return null;
    }
    public static string keyFor(Dict sym)
    {
        return null;
    }
    public string toSource()
    {
        return null;
    }
    public string ToString()
    {
        return string.Format("Symbol(%s)", _description);
    }
    public Dict valueOf()
    {
        return null;
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
