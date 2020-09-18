using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js.core
{
    public class JsNumber 
    {
    public static readonly JsNumber EPSILON = new JsNumber(2.2204460492503130808472633361816E-16);
    //
    public static readonly JsNumber MAX_SAFE_INTEGER = new JsNumber(9007199254740991L);
    //
    public static readonly JsNumber MAX_VALUE =new JsNumber( 1.79E+308);
    //
    public static readonly JsNumber MIN_SAFE_INTEGER =new JsNumber( -9007199254740991L);
    //
    public static readonly JsNumber MIN_VALUE = new JsNumber(5e-324);
    //
    public static readonly JsNumber NEGATIVE_INFINITY = new JsNumber(Double.NEGATIVE_INFINITY);
    //
    public static readonly JsNumber NaN = new JsNumber(Double.NaN);
    //
    public static readonly JsNumber POSITIVE_INFINITY = new JsNumber(Double.POSITIVE_INFINITY);
    static char[] chs = new char[36];
    static JsNumber(){
        for(int i = 0; i< 10 ; i++) {
            chs[i] = (char) ('0' + i);
        }
for (int i = 10; i < chs.Length; i++)
{
    chs[i] = (char)('A' + (i - 10));
}
    }

    ///////////..........///////////
    public static JsBoolean isFinite(object value)
{
    if (!(value instanceof Number)){
    return new JsBoolean(false);
}
return new JsBoolean(Double.isFinite(Double.parseDouble(value.ToString())));
    }
    public static JsBoolean isInteger(object value)
{
    return new JsBoolean(Onekit_JS.isNumber(value));
}
public static JsBoolean isNaN(object value)
{
    return new JsBoolean(!Onekit_JS.isNumber(value));
}
public static JsBoolean isSafeInteger(object testValue)
{
    if (isNaN(testValue).THIS)
    {
        return new JsBoolean(false);
    }
    Number value = Onekit_JS.number(testValue, 0, 0);
    string string = value.ToString();
    int dot = string.lastIndexOf(".");
    int zero = string.lastIndexOf("0");
    if (dot < 0 || ((dot == string.length() - 2)
            && (zero == string.length() - 1)))
    {
        double d = Double.parseDouble(string);
        return new JsBoolean(d >= MIN_SAFE_INTEGER.THIS.doubleValue() && d <= MAX_SAFE_INTEGER.THIS.doubleValue());
    }
    return new JsBoolean(false);
}
public static JsNumber parseFloat(object string)
{
    if (!Onekit_JS.isNumber(string))
    {
        return new JsNumber(0.0);
    }
    return new JsNumber(Double.parseDouble(string.ToString()));
}
public static JsNumber parseInt(object string)
{
    if (!Onekit_JS.isNumber(string))
    {
        return new JsNumber(0L);
    }
    return new JsNumber((long)Double.parseDouble(string.ToString()));
}
public static object Number(object value)
{
    return new JsNumber(value);

}
////////////////////////////////////////

public Number THIS;
public JsNumber(Number value)
{
    this.THIS = value;
}
public JsNumber(object value)
{
    if (value instanceof JsNumber) {
    this.THIS = ((JsNumber)value).THIS;
}else
{
    this.THIS = 0;
}
    }
    public string _toExponential(Integer fractionDigits)
{
    string string = this.ToString();
    int len = string.indexOf(".");
    if (fractionDigits == null)
    {
        if (len >= 0)
        {
            fractionDigits = string.length() - len;
        }
        else
        {
            fractionDigits = string.length() - 1;
        }
    }
    string str = string + "00000000000000000000000000000";
    if (len >= 0)
    {
        return new string(string.Format("%s.%s%se+%s",
                str.substring(0, 1),
                str.substring(1, len),
                str.substring(len + 1, fractionDigits + len),
                len - 1));
    }
    else
    {
        return new string(string.Format("%s.%se+%s",
                str.substring(0, 1),
                str.substring(1, 1 + fractionDigits),
                fractionDigits));
    }
}
public string toExponential(object fractionDigits)
{
    Integer fractionDigits_ = Onekit_JS.number(fractionDigits, 0, 0).intValue();
    return _toExponential(fractionDigits_);
}
public string toExponential()
{
    return toExponential(null);
}
//
public string toFixed(object digits)
{
    if (digits == null)
    {
        return new string(string.valueOf(THIS.longValue()));
    }
    int d = Onekit_JS.number(digits, 0, 0).intValue();
    string Format = "%." + d + "f";
    return new string(string.Format(Format, THIS));
}
public string toFixed()
{
    return toFixed(null);
}
public string toLocaleString(object locales, object options)
{
    return new string("");
}
public string toLocaleString(object locales)
{
    return toLocaleString(locales, null);
}
public string toLocaleString()
{
    return toLocaleString(null);
}
public string toPrecision(object precision)
{
    return new string("");
}
public string valueOf()
{
    return new string("");
}

public string ToString(object radix)
{
    int r = Onekit_JS.number(radix, 10, 10).intValue();
    if (THIS instanceof Integer){
    return new string(THIS.ToString());
}
if (r == 10)
{
    return new string(THIS.ToString());
}
int number = THIS.intValue();
StringBuilder sb = new StringBuilder();
bool isN = false;
while (number != 0)
{
    int index = number % r;
    if (index < 0)
    {
        isN = true;
        index += r;
    }
    sb.append(chs[index]);
    number = number / r;
}
return new string(isN ? "-" : "" + sb.reverse().ToString().toLowerCase());
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