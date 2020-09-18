using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Web;

namespace cn.onekit.js.core
{
    public interface JsFile
    {

    }
    public static class JsFile_
    {
     static   Dictionary<int, Dictionary<string, function>> allOverrides = new Dictionary<int, Dictionary<string, function>>();
    public static void setOverride(this JsFile THIS,string clazz, string method, function function)
        {
            if (!allOverrides.ContainsKey(THIS.GetHashCode()))
            {
                allOverrides.Add(THIS.GetHashCode(), new Dictionary<string, function> ());
            }
            Dictionary<string, function> overrides = allOverrides[THIS.GetHashCode()];
            overrides.Add(string.Format("{0}.{1}", clazz, method), function);
        }
        static public function getOverride(this JsFile THIS, string clazz, string method)
        {
            return allOverrides[THIS.GetHashCode()][string.Format("{0}.{1}", clazz, method)];
        }
        //////////////////////////////////////
       static public Dictionary<int, Dictionary<string, function>> allPrototypes = new Dictionary<int, Dictionary<string, function>>();
    public static  void setPrototype(this JsFile THIS,string clazz, string method, function function)
        {
            if (!allPrototypes.ContainsKey(THIS.GetHashCode()))
            {
                allPrototypes.Add(THIS.GetHashCode(), new Dictionary<string, function>());
            }
            Dictionary<string, function> prototypes = allOverrides[THIS.GetHashCode()];
            prototypes.Add(string.Format("{0}.{1}", clazz, method), function);
        }
        public static function getPrototype(this JsFile THIS, string clazz, string method, object thisArg)
        {
            function function = allPrototypes[THIS.GetHashCode()][string.Format("{0}.{1}", clazz, method)];
            function.thisArg = thisArg;
            return function;
        }
        /////////////////////////////////////
        public static string onekit_JQ(this JsFile THIS, string Format, Dict args) {
        foreach (var entry in args) {
            string str = string.Format("${{0}}", entry.Key);
        Format = Format.Replace(str, Onekit_JS.ToString(entry.Value));
        }
        return Format;
    }

////////////////////////////////////



public static object NaN = JsNumber.NaN;
        public static object undefined = null;
        public static object Infinity = JsNumber.POSITIVE_INFINITY;
        public static object Null = new Null();

/////////////////////////////////////
public static object Number(object value)
{
    return JsNumber.Number(value);
}

        public static object Boolean(object value)
{
    return new JsBoolean(value);
}

        public static Error Error(object message)
{
    return new Error(message);
}

        public static cn.onekit.js.Array Array(object length)
{
    return new cn.onekit.js.Array(length);
}

        public static Dictionary<object,object> Map(Array map)
{
    Dictionary<object,object> result = new Dictionary<object,object>();
    foreach (object temp in map) {
    Array item = (Array)temp;
    result.Add(item[0], item[1]);
}
return result;
    }

        ///////////////////////////////////////////
        public static string decodeURI(string url)
{
    return HttpUtility.UrlDecode(url);
}

        public static string decodeURIComponent(string url)
{
    return HttpUtility.UrlDecode(url);
}

public static string encodeURI(string url)
{
   
        return HttpUtility.UrlEncode(url);
   
}

        public static string encodeURIComponent(string url)
{

 
                return HttpUtility.UrlEncode(url)
                .Replace("\\+", "%20")
                .Replace("\\%21", "!")
                .Replace("\\%27", "'")
                .Replace("\\%28", "(")
                .Replace("\\%29", ")")
                .Replace("\\%7E", "~");
    }


    private static string ascii = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890";

        public static string escape(string src)
{
    StringBuilder result = new StringBuilder();
    foreach (char chr in src) {
                string str = string.Format("{0}",chr);
    if (ascii.Contains(str))
    {
        result.Append(str);
        continue;
    }
    if ("@*_+-./".Contains(str))
    {
        result.Append(str);
        continue;
    }
    StringBuilder s16 = new StringBuilder(Convert.ToString(chr,16).ToUpper());
    if (s16.Length > 2)
    {
        while (s16.Length < 4)
        {
            s16.Insert(0, "0");
        }
        s16.Insert(0, "%u");
    }
    else
    {
        while (s16.Length < 2)
        {
            s16.Insert(0, "0");
        }
        s16.Insert(0, "%");
    }
    result.Append(s16);
}
return result.ToString();
    }

        public static object isFinite(object testValue)
{
    return JsNumber.isFinite(testValue);

}

        public static object isNaN(object v)
{
    return JsNumber.isNaN(v);
}

        public static Double parseFloat(object string)
{
    try
    {
        Pattern pattern = Pattern.compile("^[+-]?[\\d]+([.][\\d]*)?([Ee][+-]?[\\d]+)?$");
        Matcher matcher = pattern.matcher(string.ToString().trim());
        StringBuilder str = new StringBuilder();
        bool flag = false;
        while (matcher.find())
        {
            str.Append(matcher.group());
            flag = true;
        }
        if (!flag)
        {
            pattern = Pattern.compile("([1-9]\\d*\\.?\\d*)|(0\\.\\d*[1-9])");
            matcher = pattern.matcher(string.ToString().trim());
            while (matcher.find())
            {
                str.Append(matcher.group());
            }
        }
        return Double.parseDouble(str.ToString());
    }
    catch (Exception e)
    {
        return Double.NaN;
    }
}

        public static object parseInt(object string, object radix)
{
    try
    {
        int flag;
        if (radix == null || !Onekit_JS.isNumber(radix))
        {
            flag = 10;
        }
        else
        {
            flag = Onekit_JS.number(radix, 0, 0).intValue();
        }
        string str = string.ToString().trim();
        long result;
        if (str.startsWith("0x"))
        {
            result = new BigInteger(str.substring(2), flag).longValue();
        }
        else if (str.startsWith("0b"))
        {
            result = new BigInteger(str.substring(2), flag).longValue();
        }
        else if (str.startsWith("0o"))
        {
            result = new BigInteger(str.substring(2), flag).longValue();
        }
        else
        {
            result = new BigInteger(str, flag).longValue();
        }
        return new JsNumber(result);
    }
    catch (Exception e)
    {
        return new string(NaN.ToString());
    }
}


        public static string unescape(string src)
{
    StringBuilder tmp = new StringBuilder();
    tmp.ensureCapacity(src.Length);
    int lastPos = 0;
    char ch;
    while (lastPos < src.Length)
    {
        int pos = src.indexOf("%", lastPos);
        if (pos == lastPos)
        {
            if (src.charAt(pos + 1) == 'u')
            {
                ch = (char)int.parseInt(src
                        .substring(pos + 2, pos + 6), 16);
                tmp.Append(ch);
                lastPos = pos + 6;
            }
            else
            {
                ch = (char)int.parseInt(src
                        .substring(pos + 1, pos + 3), 16);
                tmp.Append(ch);
                lastPos = pos + 3;
            }
        }
        else
        {
            if (pos == -1)
            {
                tmp.Append(src.substring(lastPos));
                lastPos = src.Length;
            }
            else
            {
                tmp.Append(src.substring(lastPos, pos));
                lastPos = pos;
            }
        }
    }
    return tmp.ToString();
}

/////////////////////////////////////
Console console = new Console();
        /////////////////////////////////////


        public static Class getClass(object obj)
{
    return obj.getClass();
}


        public static Float NUMBER(string string)
{
    try
    {
        return Float.parseFloat(string);
    }
    catch (Exception e)
    {
        return null;
    }
}


        public static string string(string string, params object[]vars)
{
    return string;
}

        //
        /* default string typeOf(object obj) {
             return obj.getClass().getSimpleName().toLowerCase();
         }*/

        ///////////////////////////

        public static Symbol Symbol(object description)
{
    return new Symbol(description);
}
        public static Symbol Symbol()
{
    return new Symbol();
}


    //

    private static  Dictionary<long, cn.onekit.js.core.function> _timeouts = new Dictionary<long, cn.onekit.js.core.function>();

        public static long setTimeout(object function, object delay, params object[] objs)
        {

            long id = new Random().Next();

            if (_timeouts.ContainsKey(id))
            {
                _timeouts[id].invoke(objs);
            }

        
_timeouts.Add(id, (cn.onekit.js.core.function)function);
return id;

    }

    public static long setTimeout(object function)
{
    return setTimeout(function, new JsNumber(0));
}

    public static void clearTimeout(long id)
{

    if (!_timeouts.ContainsKey(id))
    {
        return;
    }
    _timeouts.Remove(id);
}

        static Dictionary<long, Timer> _intervals = new Dictionary<long, Timer>();

        public static long setInterval(object function, object delay, params object[] objs)
{
            /*
    readonly Handler handler = new Handler() {
            override
            public void handleMessage(Message msg)
    {
        function.invoke(objs);
    }
};*/

Timer timer = new Timer();
            timer.Elapsed +=( sender,  e)=>
            {
                function.invoke(objs);
            };
long id = timer.GetHashCode();
long delay_ = Onekit_JS.number(delay, 0, 0).longValue();
            timer.Interval = delay_;
_intervals.Add(id, timer);
return id;
    }


        public static void clearInterval(long id)
{

    if (!_intervals.ContainsKey(id))
    {
        return;
    }
    _intervals[id).cancel();
    _intervals.Remove(id);
}
    }
}
