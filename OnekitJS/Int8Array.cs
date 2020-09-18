using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Int8Array extends TypedArray
    {
    public readonly static JsNumber BYTES_PER_ELEMENT = new JsNumber(1);
    public readonly static string name = "Int8Array";
    public Int8Array(object length)
    {
        super(Int8Array.class,length);
    }


public Int8Array(object buffer, object byteOffset, object length)
{
    super(Int8Array.class,buffer, byteOffset, length);
    }

    public Int8Array(object buffer, object byteOffset)
{
    super(Int8Array.class,buffer, byteOffset);
    }


    public Int8Array(Array array)
{
    super(Int8Array.class,array);
    }
    //////////////////////////////////
    public static Int8Array from(object source, object mapFn, object thisArg)
{
    return _from(Int8Array.class, source, mapFn, thisArg);
    }


    public static Int8Array of(params object[]elements)
{
    return _of(Int8Array.class, elements);
    }

}

}
