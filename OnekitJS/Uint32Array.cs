using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Uint32Array extends TypedArray
    {
    public readonly static JsNumber BYTES_PER_ELEMENT = new JsNumber(4);
    public readonly static string name = "Uint32Array";

    public <TA extends TypedArray> Uint32Array(object length)
    {
        super(Uint32Array.class, length);
    }

public < TA extends TypedArray> Uint32Array(TA typedArray) {
    super(typedArray);
}

public < TA extends TypedArray> Uint32Array(object buffer, object byteOffset, object length) {
    super(Uint32Array.class, buffer, byteOffset, length);
    }

    public < TA extends TypedArray> Uint32Array(object buffer, object byteOffset) {
    super(Uint32Array.class, buffer, byteOffset);
    }

    public < TA extends TypedArray> Uint32Array(Array array) {
    super(Uint32Array.class, array);
    }

    //////////////////////////////////
    public static Uint32Array from(Set source, function mapFn, object thisArg)
{
    return _from(Uint32Array.class, source, mapFn, thisArg);
    }

    public static Uint32Array from(Set source, function mapFn)
{
    return from(source, mapFn, null);
}

public static Uint32Array from(Set source)
{
    return from(source, null);
}

//
public static Uint32Array from(Array source, function mapFn, object thisArg)
{
    return _from(Uint32Array.class, source, mapFn, thisArg);
    }

    public static Uint32Array from(Array source, function mapFn)
{
    return from(source, mapFn, null);
}

public static Uint32Array from(Array source)
{
    return from(source, null);
}

//
public static Uint32Array from(object source, object mapFn, object thisArg)
{
    return _from(Uint32Array.class, source, mapFn, thisArg);
    }

    public static Uint32Array from(object source, object mapFn)
{
    return from(source, mapFn, null);
}

public static Uint32Array from(object source)
{
    return from(source, null);
}

public static Uint32Array of(params object[]elements)
{
    return _of(Uint32Array.class, elements);
    }


}

}
