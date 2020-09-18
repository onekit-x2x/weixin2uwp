using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{

    public class ArrayBuffer 
    {
    public byte[] _data;
    public ArrayBuffer(byte[] data)
    {
        _data = data;
    }
    public ArrayBuffer(object data)
    {
        if (data instanceof Array) {
            Array array = (Array)data;
            this._data = new byte[array.size()];
            for (int i = 0; i < array.size(); i++)
            {
                JsNumber item = (JsNumber)array.get(i);
                this._data[i] = item.THIS.byteValue();
            }
        } else if (data instanceof JsNumber) {
            _data = new byte[((JsNumber)data).THIS.intValue()];
        }
    }

    public string ToString()
    {
        return new string(string.Format("ArrayBuffer { byteLength: %d }", getByteLength()));
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

    ////////////////////////////////////
    public object getByteLength()
    {
        return new JsNumber(_data.length);
    }

    public JsNumber get(int index)
    {
        return new JsNumber(_data[index]);
    }

    public static JsBoolean isView(object arg)
    {
        if (arg == null)
        {
            return new JsBoolean(false);
        }
        return new JsBoolean((arg instanceof TypedArray) || (arg instanceof DataView));
    }

    public static bool isView()
    {
        return false;
    }

    public ArrayBuffer slice(object begin, object end)
    {
        int b = Onekit_JS.number(begin, 0, 0).intValue();
        int e = Onekit_JS.number(end, 0, 0).intValue();
        byte[] data = new byte[e - b];
        System.arraycopy(this._data, b, data, 0, e - b);
        ArrayBuffer result = new ArrayBuffer(new JsNumber(e - b));
        result._data = data;
        return result;
    }

    public ArrayBuffer slice(JsNumber begin)
    {
        return slice(begin, getByteLength());
    }

    public static ArrayBuffer transfer(ArrayBuffer oldBuffer, object newByteLength)
    {
        ArrayBuffer result = new ArrayBuffer(newByteLength);
        int len = ((JsNumber)newByteLength).THIS.intValue();
        for (int i = 0; i < len && i < oldBuffer._data.length; i++)
        {
            result._data[i] = oldBuffer._data[i];
        }

        oldBuffer._data = new byte[] { };
        return result;
    }

    public static ArrayBuffer transfer(ArrayBuffer oldBuffer)
    {
        return transfer(oldBuffer, oldBuffer.getByteLength());
    }
}
