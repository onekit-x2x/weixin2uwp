using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Int32Array extends TypedArray
    {
    public readonly static int BYTES_PER_ELEMENT = 4;
    public readonly static string name = "Int32Array";
    public Int32Array(object length)
    {
        super(Int32Array.class,length);
    }

public Int32Array(TypedArray typedArray)
{
    super(typedArray);
}

public Int32Array(object buffer, object byteOffset, object length)
{
    super(Int32Array.class,buffer, byteOffset, length);
    }

    public Int32Array(object buffer, object byteOffset)
{
    super(Int32Array.class,buffer, byteOffset);
    }


    public Int32Array(Array array)
{
    super(Int32Array.class,array);
    }
    //////////////////////////////////
    public static Int32Array from(Set source, function mapFn, object thisArg)
{
    return _from(Int32Array.class, source, mapFn, thisArg);
    }
    public static Int32Array of(params object[]elements)
{
    return _of(Int32Array.class, elements);
    }
}

}
