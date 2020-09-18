using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class DataView 
    {
    private readonly int _byteLength;
    private ArrayBuffer _buffer;
    private int _byteOffset;

    ////////////////////////////////////////////////////
    public DataView(object buffer, object byteOffset, object byteLength)
    {
        _byteOffset = Onekit_JS.number(byteOffset, 0, 0).intValue();
        _byteLength = Onekit_JS.number(byteLength, 0, 0).intValue();
        _buffer = (ArrayBuffer)buffer;
    }

    public DataView(object buffer, object byteOffset)
    {
        this(buffer, byteOffset, new JsNumber(((JsNumber)((ArrayBuffer)buffer).getByteLength()).THIS.intValue() - ((JsNumber)byteOffset).THIS.intValue()));
    }

    public DataView(object buffer)
    {
        this(buffer, new JsNumber(0));
    }

    //////////////////////////////////////////////

    public ArrayBuffer getBuffer()
    {
        return _buffer;
    }

    public object getByteLength()
    {
        return new JsNumber(_byteLength);
    }

    public object getByteOffset()
    {
        return new JsNumber(_byteOffset);
    }
    ////////////////////////////////////////////////


    public object getFloat32(object byteOffset, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        return new JsNumber((float)_get(byteOffset, "Float32", 4, ((JsBoolean)littleEndian).THIS));
    }


    public object getFloat64(object byteOffset, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        return new JsNumber((double)_get(byteOffset, "Float64", 8, ((JsBoolean)littleEndian).THIS));
    }

    public object getInt16(object byteOffset, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        return new JsNumber((short)_get(byteOffset, "Int16", 2, ((JsBoolean)littleEndian).THIS));
    }


    public object getInt32(object byteOffset, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        return (object)_get(byteOffset, "Int32", 4, ((JsBoolean)littleEndian).THIS);
    }

    public object getInt8(object byteOffset)
    {
        return new JsNumber((byte)_get(byteOffset, "Int8", 1, false));
    }

    public object getUint16(object byteOffset, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        return new JsNumber((short)_get(byteOffset, "Uint16", 2, ((JsBoolean)littleEndian).THIS));
    }
    public object getUint32(object byteOffset, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        return new JsNumber((long)_get(byteOffset, "Uint32", 4, ((JsBoolean)littleEndian).THIS));
    }

    public object getUint8(object byteOffset)
    {
        return new JsNumber((short)_get(byteOffset, "Uint8", 1, false));
    }

    public void setFloat32(object byteOffset, object value, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        _set(byteOffset, value, "Float32", 4, ((JsBoolean)littleEndian).THIS);
    }

    public void setFloat64(object byteOffset, object value, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        _set(byteOffset, value, "Float64", 8, ((JsBoolean)littleEndian).THIS);
    }


    public void setInt16(object byteOffset, object value, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        _set(byteOffset, value, "Int16", 2, ((JsBoolean)littleEndian).THIS);
    }

    public void setInt32(object byteOffset, object value, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        _set(byteOffset, value, "Int32", 4, ((JsBoolean)littleEndian).THIS);
    }

    public void setInt8(object byteOffset, object value)
    {

        _set(byteOffset, value, "Int8", 1, false);
    }



    public void setUint16(object byteOffset, object value, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        _set(byteOffset, value, "Uint16", 2, ((JsBoolean)littleEndian).THIS);
    }
    public void setUint32(object byteOffset, object value, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        _set(byteOffset, value, "Uint32", 4, ((JsBoolean)littleEndian).THIS);
    }

    public void setUint8(object byteOffset, object value, object littleEndian)
    {
        if (littleEndian == null)
        {
            littleEndian = new JsBoolean(false);
        }
        _set(byteOffset, value, "Uint8", 1, ((JsBoolean)littleEndian).THIS);
    }

    private Object _get(object byteOffset, string type, int BYTES_PER_ELEMENT, bool littleEndian)
    {

        return Onekit_JS.bytes2number(_buffer._data, type, BYTES_PER_ELEMENT, ((JsNumber)getByteOffset()).THIS.intValue() + ((JsNumber)byteOffset).THIS.intValue());
    }

    private <T extends Number>  void _set(object byteOffset, object value, string type, int BYTES_PER_ELEMENT, bool littleEndian)
    {
        Onekit_JS.number2bytes(_buffer._data, type, BYTES_PER_ELEMENT, _byteOffset + ((JsNumber)byteOffset).THIS.intValue(), value);
    }

    override
    public object get(object key)
    {
        return null;
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
