using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js.core
{
    public class Onekit_JS
    {
        /* public static   object[] array(Class componentType,int length) {
      return (object[]) java.lang.reflect.Array.newInstance(componentType, length);
  }*/


        public static Array string2Array(string string)
        {
            cn.onekit.js.Array result = new cn.onekit.js.Array();
            foreach(char chr in string)
            {
                string str = System.string.Format("{0}",chr);
                result.Add(str);
            }
            return result;
        }

        public static string unicodeToUtf8(string theString)
        {
            char aChar;
            int len = theString.Length;
            StringBuffer outBuffer = new StringBuffer(len);
            for (int x = 0; x < len;)
            {
                aChar = theString.charAt(x++);
                if (aChar == '\\')
                {
                    aChar = theString.charAt(x++);
                    if (aChar == 'u')
                    {
                        // Read the xxxx
                        int value = 0;
                        for (int i = 0; i < 4; i++)
                        {
                            aChar = theString.charAt(x++);
                            switch (aChar)
                            {
                                case '0':
                                case '1':
                                case '2':
                                case '3':
                                case '4':
                                case '5':
                                case '6':
                                case '7':
                                case '8':
                                case '9':
                                    value = (value << 4) + aChar - '0';
                                    break;
                                case 'a':
                                case 'b':
                                case 'c':
                                case 'd':
                                case 'e':
                                case 'f':
                                    value = (value << 4) + 10 + aChar - 'a';
                                    break;
                                case 'A':
                                case 'B':
                                case 'C':
                                case 'D':
                                case 'E':
                                case 'F':
                                    value = (value << 4) + 10 + aChar - 'A';
                                    break;
                                default:
                                    throw new IllegalArgumentException(
                                            "Malformed   \\uxxxx   encoding.");
                            }
                        }
                        outBuffer.append((char)value);
                    }
                    else
                    {
                        if (aChar == 't')
                            aChar = '\t';
                        else if (aChar == 'r')
                            aChar = '\r';
                        else if (aChar == 'n')
                            aChar = '\n';
                        else if (aChar == 'f')
                            aChar = '\f';
                        outBuffer.append(aChar);
                    }
                }
                else
                    outBuffer.append(aChar);
            }
            return outBuffer.ToString();
        }

        public static Integer float2integer(Double number)
        {
            double d = number;
            if (number.intValue() == number)
            {
                return Integer.valueOf((int)d);
            }
            else
            {
                return number.intValue();
            }
        }

        public static bool isNumber(object v)
        {
            /*if (v == null) {
                return false;
            }
            Object value = ((Number) v).to();
            if (value instanceof Number) {
                return !value.equals(Double.NaN);
            }
            try {
                Double.parseDouble(value.ToString());
                return true;
            } catch (Exception e) {
                return false;
            }*/
            return v instanceof JsNumber;
        }

        private static Number number(Object value)
        {
            if (value == null)
            {
                return 0;
            }
            if (value instanceof string) {
                StringBuilder string = new StringBuilder(((string)value).toLowerCase());
                if (string.ToString().equals(""))
                {
                    return 0;
                }
                if (string.ToString().equals("infinity"))
                {
                    return JsNumber.POSITIVE_INFINITY.THIS;
                }
                if (string.ToString().equals("-infinity"))
                {
                    return JsNumber.NEGATIVE_INFINITY.THIS;
                }
                int object = string.indexOf("e+");
                if (object >= 0)
                {
                    int n = Integer.parseInt(string.substring(object + 2));
                    string = new StringBuilder(string.substring(0, object));
                    for (int i = 0; i < n; i++)
                    {
                        string.append("0");
                    }
                    int dot = string.indexOf(".");
                    if (dot >= 0)
                    {
                        string = new StringBuilder(string.substring(0, dot) + string.substring(dot + 1, dot + n + 1)
                                + "." + string.substring(dot + n + 1));
                    }
                }
                int dot = string.indexOf(".");
                if (dot >= 0)
                {
                    double d = Double.parseDouble(string.ToString());
                    if (Integer.parseInt(string.substring(0, dot)) == 0)
                    {
                        return (int)d;
                    }
                    else
                    {
                        return d;
                    }
                }
                if (string.ToString().startsWith("0x"))
                {
                    return new BigInteger(string.substring(2), 16).longValue();
                }
                else if (string.ToString().startsWith("0b"))
                {
                    return new BigInteger(string.substring(2), 2).longValue();
                }
                else if (string.ToString().startsWith("0o"))
                {
                    return new BigInteger(string.substring(2), 8).longValue();
                }
                else
                {
                    try
                    {
                        return Integer.valueOf(string.ToString());
                    }
                    catch (Exception e)
                    {
                        return JsNumber.NaN.THIS;
                    }
                }
            } else
            {
                return (Number)value;
            }
        }

        public static Number number(object value, Object nullValue, Object nanValue)
        {
            if (value == null)
            {
                return (Number)nullValue;
            }
            if (!isNumber(value))
            {
                return (Number)nanValue;
            }
            return number(value);
        }

        public static string ToString(Object value)
        {
            if (value == null)
            {
                return "undefined";
            }
            if (value instanceof string) {
                return string.Format("\"%s\"", value);
            } else
            {
                return value.ToString();
            }
        }

        /*
            public static  Number bytes2number(Array data, string name, int size, int byteOffset) {
                List<Byte> bytes = new ArrayList<>();
                for(object item :data){
                    bytes.Add(((NUMBER)item).THIS.byteValue());
                }
                return bytes2number(bytes.toArray(new Byte[bytes.size()]),name,size,byteOffset);
            }*/
        public static Number bytes2number(byte[] data, string name, int size, int byteOffset)
        {
            long value = 0;
            for (int i = 0; i < size; i++)
            {
                value |= ((long)(data[byteOffset + i] & 0xff)) << (8 * i);
            }
            Number result;
            switch (name)
            {
                case "Int8":
                    if (value >= 128)
                    {
                        value -= 256;
                    }
                    result = (int)value;
                    break;
                case "Uint8Clamped":
                case "Uint8":
                    result = (int)value;
                    break;
                case "Int16":
                    result = (int)value;
                    break;
                case "Uint16":
                    result = (int)value;
                    break;
                case "Int32":
                    result = (int)value;
                    break;
                case "Uint32":
                    result = value;
                    break;
                case "Float32":
                    result = Float.intBitsToFloat((int)value);
                    break;
                case "Float64":
                    result = Double.longBitsToDouble(value);
                    break;
                default:
                    throw new Error(new string(name + ""));
            }
            return result;
        }

        public static void number2bytes(byte[] data, string name, int size, int byteOffset, object v)
        {
            Number value = ((JsNumber)v).THIS;
            long number;
            switch (name)
            {
                case "Float32":
                    number = Float.floatToRawIntBits(value.floatValue());
                    break;
                case "Float64":
                    number = Double.doubleToRawLongBits(value.doubleValue());
                    break;
                case "Int8":
                    number = Short.toUnsignedLong(value.byteValue());
                    break;
                case "Uint8":
                case "Uint8Clamped":
                    number = Short.toUnsignedLong(value.byteValue());
                    break;
                case "Int16":
                    number = Short.toUnsignedLong(value.shortValue());
                    break;
                case "Uint16":
                    number = Short.toUnsignedLong(value.shortValue());
                    break;
                case "Int32":
                    number = value.intValue();
                    break;
                case "Uint32":
                    number = value.longValue();
                    break;
                default:
                    throw new Error(new string(name + ""));
            }
            for (int i = 0; i < size; i++)
            {
                data[byteOffset + i] = (byte)((number >> 8 * i) & 0xff);
            }
        }

        /*
            public static bool isInteger(double number) {
                return (long)number==number;
            }
        */

        public static bool isEmpty(string string)
        {
            return string == null || string == "";
        }

        public static bool is(Object object) {
        if (object == null) {
            return false;
        }
        if (object instanceof Null) {
            return false;
    }
        if (object instanceof JsNumber) {
            JsNumber value = (JsNumber)object;
            return is(value.THIS.doubleValue() != 0);
        } else if (object instanceof string) {
    string string = (string)object;
    return !string.THIS.equals("");
} else if (object instanceof JsBoolean) {
    JsBoolean bool = (JsBoolean)object;
    return bool.THIS;
} else
{
    Log.e("[is]===========" + new java.util.Date().getTime(), object.getClass().getSimpleName());
}
return true;
    }

    public static object or(object object1, object object2)
{
    return object1 != null ? object1 : object2;
}
/*
    public static Number p(object x, object y) {
        Number a = OnekitJS.number(x);
        Number b = OnekitJS.number(y);
        double value = a.doubleValue() * b.doubleValue();
        return OnekitJS.float2integer(value);
    }
*/
public static Class Import(string url)
{
    if (url.endsWith(".js"))
    {
        url = url.substring(0, url.length() - ".js".length());
    }
    url = TheKit.fixPath("/" + TheKit.currentUrl, url);
    string name = TheKit.url2class(Android.context, url);
    try
    {
        return Class.forName(name);
    }
    catch (ClassNotFoundException e)
    {
        e.printStackTrace();
        return null;
    }
}

public static object plus(object a, object b)
{
    if (Onekit_JS.isNumber(a) && Onekit_JS.isNumber(b))
    {
        return new JsNumber(((JsNumber)a).THIS.doubleValue() + ((JsNumber)b).THIS.doubleValue());
    }
    else
    {
        return new string(a.ToString() + b.ToString());
    }
}
public static object subtract(object a, object b)
{
    return new JsNumber(((JsNumber)a).THIS.doubleValue() - ((JsNumber)b).THIS.doubleValue());

}
public static object multiply(object a, object b)
{
    return new JsNumber(((JsNumber)a).THIS.doubleValue() * ((JsNumber)b).THIS.doubleValue());

}
public static object divide(object a, object b)
{
    return new JsNumber(((JsNumber)a).THIS.doubleValue() / ((JsNumber)b).THIS.doubleValue());

}
    }
}
