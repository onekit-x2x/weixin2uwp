using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Uint8Array extends TypedArray
    {
    public readonly static JsNumber BYTES_PER_ELEMENT = new JsNumber(1);
    public readonly static string name = "Uint8Array";

    public <TA extends TypedArray> Uint8Array(JsNumber length)
    {
        super(Uint8Array.class, length);
    }

public < TA extends TypedArray> Uint8Array(TA typedArray) {
    super(typedArray);
}

public < TA extends TypedArray> Uint8Array(object buffer, object byteOffset, object length) {
    super(Uint8Array.class, buffer, byteOffset, length);
    }

    public < TA extends TypedArray> Uint8Array(object buffer, object byteOffset) {
    super(Uint8Array.class, buffer, byteOffset);
    }

    public < TA extends TypedArray> Uint8Array(object buffer) {
    super(Uint8Array.class, buffer);
    }

    public < TA extends TypedArray> Uint8Array(Array array) {
    super(Uint8Array.class, array);
    }

    //////////////////////////////////
    public static Uint8Array from(Set source, function mapFn, object thisArg)
{
    return _from(Uint8Array.class, source, mapFn, thisArg);
    }
    public static Uint8Array of(params object[]elements)
{
    return _of(Uint8Array.class, elements);
    }
}

}
