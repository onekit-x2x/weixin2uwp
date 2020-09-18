using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Float32Array extends TypedArray<Double> {
    public readonly static JsNumber BYTES_PER_ELEMENT = new JsNumber(4);
    public readonly static string name = "Float32Array";
    public Float32Array(object length)
    {
        super(Float32Array.class,length);
    }

public Float32Array(TypedArray<Double> typedArray)
{
    super(typedArray);
}

public Float32Array(object buffer, object byteOffset, object length)
{
    super(Float32Array.class,buffer, byteOffset, length);
    }

    public Float32Array(object buffer, object byteOffset)
{
    super(Float32Array.class,buffer, byteOffset);
    }


    public Float32Array(Array array)
{
    super(Float32Array.class,array);
    }
    //////////////////////////////////
    public static Float32Array from(Set source, function mapFn, object thisArg)
{
    return _from(Float32Array.class, source, mapFn, thisArg);
    }
    public static Float32Array of(params object[]elements)
{
    return _of(Float32Array.class, elements);
    }
}

}
