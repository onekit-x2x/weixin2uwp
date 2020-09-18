using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Float64Array extends TypedArray<Double> {
    public readonly static JsNumber BYTES_PER_ELEMENT = new JsNumber(8);
    public readonly static string name = "Float64Array";
    public Float64Array(object length)
    {
        super(Float64Array.class,length);
    }

public Float64Array(TypedArray<Double> typedArray)
{
    super(typedArray);
}

public Float64Array(object buffer, object byteOffset, object length)
{
    super(Float64Array.class,buffer, byteOffset, length);
    }

    public Float64Array(object buffer, object byteOffset)
{
    super(Float64Array.class,buffer, byteOffset);
    }


    public Float64Array(Array array)
{
    super(Float64Array.class,array);
    }
    //////////////////////////////////
    public static Float64Array from(Set source, function mapFn, object thisArg)
{
    return _from(Float64Array.class, source, mapFn, thisArg);
    }
    public static Float64Array of(params object[]elements)
{
    return _of(Float64Array.class, elements);
    }
}

}
