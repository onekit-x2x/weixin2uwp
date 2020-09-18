using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Int16Array extends TypedArray
    {
    public readonly static JsNumber BYTES_PER_ELEMENT = new JsNumber(2);
    public readonly static string name = "Int16Array";
    public Int16Array(object length)
    {
        super(Int16Array.class,length);
    }

public Int16Array(TypedArray typedArray)
{
    super(typedArray);
}

public Int16Array(object buffer, object byteOffset, object length)
{
    super(Int16Array.class,buffer, byteOffset, length);
    }

    public Int16Array(object buffer, object byteOffset)
{
    super(Int16Array.class,buffer, byteOffset);
    }

    public Int16Array(Array array)
{
    super(Int16Array.class,array);
    }
    //////////////////////////////////
    public static Int16Array from(Set source, function mapFn, object thisArg)
{
    return _from(Int16Array.class, source, mapFn, thisArg);
    }
    public static Int16Array of(params object[]elements)
{
    return _of(Int16Array.class, elements);
    }
}

}
