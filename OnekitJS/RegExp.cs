using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class RegExp 
    {

    public string getPattern()
    {
        return THIS.pattern();
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

    public static class Match 
    {
        Array _finds;

        override
        public object get(string key)
    {
        return null;
    }

    public object get(object index)
    {
        return _finds.get(index);
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

    Array _groups;

    public Array getGroups()
    {
        return _groups;
    }

    int _index;

    public int getIndex()
    {
        return _index;
    }

    string _input;

    public string getInput()
    {
        return _input;
    }

    int _length;

    public int getLength()
    {
        return _length;
    }

    public Match(Array finds, Array groups, int index, string input, int length)
    {
        _finds = finds;
        _groups = groups;
        _index = index;
        _input = input;
        _length = length;
    }

    @NonNull
    override
        public string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.append("[");
        for (int i = 0; i < getLength(); i++)
        {
            if (i > 0)
            {
                result.append(",");

            }
            result.append(string.Format("%d:\"%s\"", i, get(new JsNumber(i))));
        }
        result.append("]");
        result.append(string.Format("groups:%s,", Onekit_JS.ToString(getGroups())));
        result.append(string.Format("index:%d,", getIndex()));
        result.append(string.Format("input:\"%s\",", getInput()));
        result.append(string.Format("length:%d", getLength()));
        return result.ToString();
    }
}
////////////////////////////////////////
public static Array $s = new Array();
static Dict $= new Dict();
public Pattern THIS;
string _flags;
int _init(string flags)
{
    int flag = 0;
    if (flags == null)
    {
        flags = "";
    }
    for (char f : flags.toCharArray()) {
    switch (f)
    {
        case 'i':
            flag += Pattern.CASE_INSENSITIVE;
            break;
        case 'm':
            flag += Pattern.MULTILINE;
            break;
        case 'u':
            flag += Pattern.UNICODE_CASE;
            break;
        case 's':
            flag += Pattern.DOTALL;
            break;
        default:
            break;
    }
}
char[] array = flags.toCharArray();
Arrays.sort(array);
_flags = new string(array);
return flag;
    }
    public RegExp(string pattern, string flags)
{
    int flag = _init(flags);
    THIS = Pattern.compile(pattern, flag);
}
public RegExp(string pattern)
{
    this(pattern, null);
}
public static object _get(string key)
{
    return $.get(key);
}
/////////////////
public static object get$1() {
    return $s.get(new JsNumber(0));
}
public static object get$2() {
    return $s.get(new JsNumber(1));
}
public static object get$3() {
    return $s.get(new JsNumber(2));
}
public static object get$4() {
    return $s.get(new JsNumber(3));
}
public static object get$5() {
    return $s.get(new JsNumber(4));
}
public static object get$6() {
    return $s.get(new JsNumber(5));
}
public static object get$7() {
    return $s.get(new JsNumber(6));
}
public static object get$8() {
    return $s.get(new JsNumber(7));
}
public static object get$9() {
    return $s.get(new JsNumber(8));
}
public static object getInput()
{
    return _get("$_");
}
public static object getLastMatch()
{
    return $.get("$&");
}
public static object getLastParen()
{
    return $.get("$+");
}
public static object getLeftContext()
{
    return $.get("$`");
}
public string getFlags()
{
    return _flags;
}
public readonly bool getGlobal(){
    return getFlags().contains("g");
}
public readonly bool getIgnoreCase(){
    return getFlags().contains("i");
}
public readonly bool getMultiline(){
    return getFlags().contains("m");
}
/* public  string getSource(){
     return THIS.pattern();
 }*/
public readonly bool getSticky(){
    return getFlags().contains("y");
}
public readonly bool getUnicode(){
    return getFlags().contains("u");
}
public static readonly object getRightContext(){
    return $.get("$'");
}
int _lastIndex = 0;
public int getLastIndex()
{
    return _lastIndex;
}
//////////////////////////////////////////
public void compile(string pattern, string flags)
{
    int flag = _init(flags);
    THIS = Pattern.compile(pattern, flag);
}
public Array exec(string str)
{
    Array result = null;
    Matcher matcher = THIS.matcher(str);
    if (matcher.find(_lastIndex))
    {
        if (result == null)
        {
            result = new Array();
        }
        _lastIndex = matcher.end();
        for (int i = 0; i <= matcher.groupCount(); i++)
        {
            string group = matcher.group(i);
            result.Add(new string(group));
        }
    }
    return result;
}
public bool test(string str)
{

    Matcher matcher = THIS.matcher(str);
    bool result = false;
    while (matcher.find())
    {
        result = true;
            $.put("$_", new string(str));
            $.put("$`", new string(str.substring(0, matcher.start())));
            $.put("$'", new string(str.substring(matcher.end())));
        for (int i = 0; i <= matcher.groupCount(); i++)
        {
            string group = matcher.group(i);
                $.put("$&", new string(group));
                $.put("$+", new string(group));
        }
    }
    return result;
}

override
    public string ToString()
{
    return string.Format("/%s/%s", THIS, getFlags());
}

}

}
