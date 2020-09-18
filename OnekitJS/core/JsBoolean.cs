using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js.core
{
    public class JsBoolean 
    {
    public bool THIS;
    public JsBoolean(bool value)
    {
        THIS = value;
    }
    public JsBoolean(object value)
    {
        if (value == null)
        {
            THIS = false;
        }
        if (value is string) {
            string s = (string)value;
            THIS = s.Length > 0;
        } else if (value is JsBoolean) {
            THIS = ((JsBoolean)value).THIS;
        } else if (value is JsNumber) {
            THIS = ((JsNumber)value).THIS.doubleValue() != 0;
        } else
        {
            THIS = true;
        }
    }
    public static string ToString(Boolean THIS)
    {
        return THIS.ToString();
    }
    public static JsBoolean valueof(object value)
    {
        return new JsBoolean(value);
    }
}
}
