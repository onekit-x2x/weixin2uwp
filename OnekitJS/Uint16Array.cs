using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Uint16Array extends TypedArray
    {
    public readonly static JsNumber BYTES_PER_ELEMENT = new JsNumber(2);
    public readonly static string name = "Uint16Array";

    public <TA extends TypedArray> Uint16Array(object length)
    {
        super(Uint16Array.class, length);
    }

public < TA extends TypedArray> Uint16Array(TA typedArray) {
    super(typedArray);
}

public < TA extends TypedArray> Uint16Array(object buffer, object byteOffset, object length) {
    super(Uint16Array.class, buffer, byteOffset, length);
    }

    public < TA extends TypedArray> Uint16Array(object buffer, object byteOffset) {
    super(Uint16Array.class, buffer, byteOffset);
    }


    public < TA extends TypedArray> Uint16Array(Array array) {
    super(Uint16Array.class, array);
    }

    //////////////////////////////////
    public static Uint16Array from(Set source, function mapFn, object thisArg)
{
    return _from(Uint16Array.class, source, mapFn, thisArg);
    }

    public static Uint16Array from(Set source, function mapFn)
{
    return from(source, mapFn, null);
}

public static Uint16Array from(Set source)
{
    return from(source, null);
}

//
public static Uint16Array from(Array source, function mapFn, object thisArg)
{
    return _from(Uint16Array.class, source, mapFn, thisArg);
    }

    public static Uint16Array from(Array source, function mapFn)
{
    return from(source, mapFn, null);
}

public static Uint16Array from(Array source)
{
    return from(source, null);
}

//
public static Uint16Array from(object source, object mapFn, object thisArg)
{
    return _from(Uint16Array.class, source, mapFn, thisArg);
    }

    public static Uint16Array from(object source, object mapFn)
{
    return from(source, mapFn, null);
}

public static Uint16Array from(object source)
{
    return from(source, null);
}

public static Uint16Array of(params object[]elements)
{
    return _of(Uint16Array.class, elements);
    }
}

}
