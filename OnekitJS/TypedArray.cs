﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public abstract class TypedArray<T extends Number> : Iterable, object {

    private int _byteLength;
    private int _byteOffset;
    public ArrayBuffer _buffer;

    protected static <TA extends TypedArray> int _BYTES_PER_ELEMENT(Class<TA> clazz)
    {
        try
        {
            return (int)clazz.getField("BYTES_PER_ELEMENT").get(null);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            return 0;
        }
    }
    protected static <TA extends TypedArray> string _name(Class<TA> clazz)
    {
        try
        {
            return (string)clazz.getField("name").get(null);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            return null;
        }
    }

    override
    public string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.append("[");
        for (int i = 0; i < getLength().THIS.intValue(); i++)
        {
            if (i > 0)
            {
                result.append(",");
            }
            object v = get(i);
            result.append(v);
        }
        result.append("]");
        return result.ToString();
    }
    override
    public IIterator<object> iterator()
    {
        return new IIterator<object>() {
            int index = 0;

        override
            public bool hasNext()
        {
            return index < getLength().THIS.intValue();
        }

        override
            public object next()
        {
            return get(index++);
        }
    };
}
///////////////////////////////////////////////////

public object get(Integer index)
{
    int size = _BYTES_PER_ELEMENT(getClass());
    return new JsNumber(Onekit_JS.bytes2number(_buffer._data, _name(getClass()).replace("Array", ""), size, size * index));
}

public void set(object index, object value)
{
    _set(Onekit_JS.number(index, 0, 0).intValue(), this, value);
}

public static int _index(TypedArray array, int index)
{
    if (index >= 0)
    {
        return index;
    }
    return array.getLength().THIS.intValue() + index;
}
////////////////////////////////////////////////////////


public < TA extends TypedArray> TypedArray(Class<TA> clazz, object arg) {
    /*if(arg instanceof NUMBER){
        int len=OnekitJS.number(arg,0,0).intValue()* _BYTES_PER_ELEMENT(clazz);
        this(clazz, new ArrayBuffer(new NUMBER(len)),new NUMBER(arg));
    }else if(arg instanceof ArrayBuffer){
        this(clazz, arg, new NUMBER(0));
    }*/
}

public < TA extends TypedArray>  TypedArray(TA typedArray) {
    this(typedArray.getClass(), new ArrayBuffer(typedArray.getBuffer()._data.clone()));
}

public < TA extends TypedArray> TypedArray(Class<TA> clazz, object buffer, object byteOffset, object length) {
    this._byteOffset = Onekit_JS.number(byteOffset, 0, 0).intValue();
    this._buffer = (ArrayBuffer)buffer;
    this._byteLength = Onekit_JS.number(length, 0, 0).intValue();
}
public < TA extends TypedArray> TypedArray(Class<TA> clazz, object buffer, object byteOffset) {
    this(clazz, buffer, byteOffset, new JsNumber(((JsNumber)((ArrayBuffer)buffer).getByteLength()).THIS.intValue() - ((JsNumber)byteOffset).THIS.intValue()));
}

public < TA extends TypedArray> TypedArray(Class<TA> clazz, Array array) {
    this(clazz, _array2buffer(clazz, array));
}
public < TA extends TypedArray> TypedArray(Class<TA> clazz, ArrayBuffer buffer) {
    this(clazz, buffer, new JsNumber(0));
}
private static < TA extends TypedArray> ArrayBuffer _array2buffer(Class<TA> clazz, Array array){
    ArrayBuffer result = new ArrayBuffer(new JsNumber(array.size() * _BYTES_PER_ELEMENT(clazz)));

    for (int i = 0; i < array.size(); i++)
    {
        Onekit_JS.number2bytes(result._data, clazz.getSimpleName().replace("Array", ""), _BYTES_PER_ELEMENT(clazz), _BYTES_PER_ELEMENT(clazz) * i, _fix(clazz, array.get(i)));

    }
    return result;
}
////////////////////////////////////////////////////

public ArrayBuffer getBuffer()
{
    return _buffer;
}

public JsNumber getByteLength()
{
    return new JsNumber(_byteLength);
}

public JsNumber getByteOffset()
{
    return new JsNumber(_byteOffset);
}

public JsNumber getLength()
{
    int size = _BYTES_PER_ELEMENT(this.getClass());
    return new JsNumber(getByteLength().THIS.intValue() / size);
}
private static object _fix(Class clazz, object flag)
{
    if (flag.equals(Double.NaN))
    {
        return new JsNumber(0.0);
    }
    string str = flag.ToString();
    string name = clazz.getSimpleName().replace("Array", "");
    Number value;
    switch (name)
    {
        case "Int8":
        case "Uint8Clamped":
        case "Uint8":
        case "Int16":
        case "Uint16":
        case "Int32":
            value = Double.valueOf(str).intValue(); break;
        case "Uint32":
            value = long.valueOf(str); break;
        case "Float32":
            value = Float.valueOf(str); break;
        case "Float64":
            value = Double.valueOf(str); break;
        default:
            throw new Error(new string(name));
    }
    return new JsNumber(value);
}
public static < TA extends TypedArray> void _set(int index, TA typedArray, object flag) {
    Class clazz = typedArray.getClass();


    int size = _BYTES_PER_ELEMENT(clazz);
    Onekit_JS.number2bytes(typedArray._buffer._data, _name(clazz).replace("Array", ""), size, index * size, _fix(clazz, flag));
}

protected static < TA extends TypedArray>  TA _from(Class<TA> clazz, object source, object fn, object thisArg) {
    function mapFn = (function)fn;
    if (source instanceof Set) {
        return _from(clazz, (Set)source, mapFn, thisArg);
    }else if (source instanceof string) {
        return _from(clazz, (string)source, mapFn, thisArg);
    }else if (source instanceof Array) {
        return _from(clazz, (Array)source, mapFn, thisArg);
    }else
    {
        return null;
    }
}
private static < TA extends TypedArray> TA _from(Class<TA> clazz, Set source, function mapFn, object thisArg) {
    try
    {

        ArrayBuffer buffer = new ArrayBuffer(new JsNumber(source.getSize() * _BYTES_PER_ELEMENT(clazz)));
        TA result = clazz.getConstructor(ArrayBuffer.class).newInstance(buffer);
int i = 0;
for (object element : source)
{
    object flag;
    if (mapFn != null)
    {
        flag = mapFn.invoke(element);
    }
    else
    {
        flag = element;
    }

    _set(i++, result, flag);
}
return result;
        } catch (Exception e)
{
    e.printStackTrace();
    return null;
}
    }

    private static < TA extends TypedArray>  TA _from(Class<TA> clazz, Array source, function mapFn, object thisArg) {
    return _from(clazz, new Set(source), mapFn, thisArg);
}
private static < TA extends TypedArray>  TA _from(Class<TA> clazz, string source, function mapFn, object thisArg) {
    Array array = Onekit_JS.string2Array(source.THIS);
    return _from(clazz, new Set(array), mapFn, thisArg);
}

public static < TA extends TypedArray> TA _of(Class<TA> clazz, params object[] elements) {
    try
    {

        ArrayBuffer buffer = new ArrayBuffer(new JsNumber(elements == null ? 1 : elements.length * _BYTES_PER_ELEMENT(clazz)));
        TA result = clazz.getConstructor(ArrayBuffer.class).newInstance(buffer);
if (elements == null)
{
    result._buffer = new ArrayBuffer(new JsNumber(1 * result._BYTES_PER_ELEMENT(clazz)));
    result.set(new JsNumber(0), new JsNumber(0));
}
else
{
    result._buffer = new ArrayBuffer(new JsNumber(elements.length * result._BYTES_PER_ELEMENT(clazz)));
    for (int i = 0; i < elements.length; i++)
    {
        object element = elements[i];
        if (element == null)
        {
            element = new JsNumber(0);
        }
        _set(i, result, element);
    }
}
return result;
        } catch (Exception e)
{
    e.printStackTrace();
    return null;
}
    }


    ////////////////////////////////////////////////////
    public < TA extends TypedArray> TA copyWithin(object target, object start, object end) {
    if (end == null)
    {
        end = this.getLength();
    }
    int t = Onekit_JS.number(target, 0, 0).intValue();
    int s = Onekit_JS.number(start, 0, 0).intValue();
    int e = Onekit_JS.number(end, 0, 0).intValue();
    for (int i = s, j = t; i < e && i < getLength().THIS.intValue() && j < getLength().THIS.intValue(); i++, j++)
    {
        object element = get(i);
        set(new JsNumber(j), element);
    }
    return (TA)this;
}

public Iterator entries()
{
    return new Iterator(new IIterator<object>() {
            int index = 0;

    override
            public bool hasNext()
    {
        return index < getLength().THIS.intValue();
    }

    override
            public object next()
    {
        return get(index++);
    }
}) {
    int i = 0;

    override
            public Array getValue(Object value)
    {
        return new Array() {
                    Add(new JsNumber(i++));
        Add((object)value);
    }
};
            }
        };
    }

        public JsBoolean every(function callback, object thisArg)
{
    callback.thisArg = thisArg;
    for (int i = 0; i < getLength().THIS.intValue(); i++)
    {
        object element = get(i);
        if (element == null)
        {
            continue;
        }

        if (!Onekit_JS.is (callback.invoke(element, new JsNumber(i), this)))
        {
            return new JsBoolean(false);
        }
    }
    return new JsBoolean(true);
}

public JsBoolean every(function callback)
{
    return every(callback, null);
}

        //
        < TA extends TypedArray> TA _fill(object value, int start, int end) {
    start = _index(this, start);
    end = _index(this, end);
    for (int i = start; i >= 0 && i < end && i < getLength().THIS.intValue(); i++)
    {
        set(new JsNumber(i), value);
    }
    return (TA)this;
}

public < TA extends TypedArray> TA fill(object value, object start, object end) {
    int start_ = Onekit_JS.number(start, 0, 0).intValue();
    int end_ = Onekit_JS.number(end, 0, 0).intValue();
    return _fill(value, start_, end_);
}

public < TA extends TypedArray> TA fill(object value, object start) {
    return fill(value, start, new JsNumber(getLength()));
}

public < TA extends TypedArray> TA fill(object value) {
    return fill(value, new JsNumber(0));
}

public < TA extends TypedArray>  TA filter(function callback, object thisArg) {

    callback.thisArg = thisArg;
    Array array = new Array();
    for (int i = 0; i < getLength().THIS.intValue(); i++)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        if (Onekit_JS.is (callback.invoke(element, new JsNumber(i), this)))
        {
            array.Add(element);
        }
    }
    Class<TA> clazz = (Class<TA>)getClass();
    return TA._of(clazz, array);
}

public < TA extends TypedArray> TA filter(function callback) {
    return filter(callback, null);
}

public object find(function callback, object thisArg)
{
    callback.thisArg = thisArg;
    for (int i = 0; i < getLength().THIS.intValue(); i++)
    {
        object element = this.get(i);
        if (Onekit_JS.is (callback.invoke(element, new JsNumber(i), this)))
        {
            return element;
        }
    }
    return null;
}

public object find(function callback)
{
    return find(callback, null);
}

public JsNumber findIndex(function callback, object thisArg)
{
    callback.thisArg = thisArg;
    for (int i = 0; i < getLength().THIS.intValue(); i++)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        if (Onekit_JS.is (callback.invoke(element, new JsNumber(i), this)))
        {
            return new JsNumber(i);
        }
    }
    return new JsNumber(-1);
}

public JsNumber findIndex(function callback)
{
    return findIndex(callback, null);
}

public void forEach(function callback, object thisArg)
{
    callback.thisArg = thisArg;
    for (int i = 0; i < getLength().THIS.intValue(); i++)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        callback.invoke(element, new JsNumber(i), this);
    }

}

public void forEach(function callback)
{
    forEach(callback, null);
}

//
public JsBoolean includes(object valueToFind, object index)
{
    int idx = Onekit_JS.number(index, 0, 0).intValue();
    double target;
    if (Onekit_JS.isNumber(valueToFind))
    {
        target = Onekit_JS.number(valueToFind, 0, 0).doubleValue();
    }
    else
    {
        target = 0;
    }
    for (int i = idx; i < getLength().THIS.intValue(); i++)
    {
        double element = Onekit_JS.number(this.get(i), 0, 0).doubleValue();
        if (target == element)
        {
            return new JsBoolean(true);
        }
    }

    return new JsBoolean(false);
}

public JsBoolean includes(object valueToFind)
{
    return includes(valueToFind, new JsNumber(0));
}

//
public JsNumber indexOf(object searchElement, int fromIndex)
{
    double target;
    if (Onekit_JS.isNumber(searchElement))
    {
        target = Onekit_JS.number(searchElement, 0, 0).doubleValue();
    }
    else
    {
        target = 0;
    }
    fromIndex = _index(this, fromIndex);
    for (int i = fromIndex; i < getLength().THIS.intValue(); i++)
    {
        double element = Onekit_JS.number(get(i), 0, 0).doubleValue();
        if (target == element)
        {
            return new JsNumber(i);
        }
    }
    return new JsNumber(-1);
}

public JsNumber indexOf(object searchElement)
{
    return indexOf(searchElement, 0);
}


public string _join(string separator)
{
    StringBuilder result = new StringBuilder();
    for (int i = 0; i < getLength().THIS.intValue(); i++)
    {
        if (i > 0)
        {
            result.append(separator);
        }
        result.append(get(i));
    }
    return result.ToString();
}

public string join(object separator)
{
    if (separator == null)
    {
        separator = new string(",");
    }
    return new string(_join(separator.ToString()));
}

public Iterator keys()
{
    return new Iterator(new IIterator<object>() {
                int index = 0;

    override
                public bool hasNext()
    {
        return index < getLength().THIS.intValue();
    }

    override
                public object next()
    {
        return get(index++);
    }
}) {
    override
                public Integer getValue(Object value)
    {
        return index++;
    }

    int index = 0;
};
        }

        public JsNumber lastIndexOf(object searchElement, JsNumber fromIndex)
{
    if (fromIndex == null)
    {
        fromIndex = new JsNumber(getLength().THIS.intValue() - 1);
    }
    double target;
    if (Onekit_JS.isNumber(searchElement))
    {
        target = Onekit_JS.number(searchElement, 0, 0).doubleValue();
    }
    else
    {
        target = 0;
    }
    int index = _index(this, fromIndex.THIS.intValue());
    for (int i = index; i >= 0; i--)
    {
        double element = Onekit_JS.number(get(i), 0, 0).doubleValue();
        if (element == target)
        {
            return new JsNumber(i);
        }
    }
    return new JsNumber(-1);
}


//
public < TA extends TypedArray>  TA map(function callback, object thisArg) {
    callback.thisArg = thisArg;
    Array array = new Array();
    for (int i = 0; i < getLength().THIS.intValue(); i++)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        Class<TA> clazz = (Class<TA>)getClass();
        object item = callback.invoke(element);
        array.Add(_fix(clazz, item));
    }
    Class<TA> clazz = (Class<TA>)getClass();
    return TA._of(clazz, array.toArray(new object[0]));
}

public < TA extends TypedArray> TA map(function callback) {
    return map(callback, null);
}


public object reduce(function callback, object initialValue)
{
    if (initialValue == null)
    {
        initialValue = get(0);
    }
    for (int i = 0; i < getLength().THIS.intValue(); i++)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        initialValue = callback.invoke(initialValue, element, new JsNumber(i), this);
    }
    return initialValue;
}

public object reduce(function callback)
{
    return reduce(callback, null);
}

public object reduceRight(function callback, object initialValue)
{
    if (initialValue == null)
    {
        initialValue = get(0);
    }
    for (int i = getLength().THIS.intValue() - 1; i >= 0; i--)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        initialValue = callback.invoke(initialValue, element, new JsNumber(i), this);
    }
    return initialValue;
}

public object reduceRight(function callback)
{
    return reduceRight(callback, null);
}

public < TA extends TypedArray> TA reverse() {

    Array array = new Array();
    for (int i = getLength().THIS.intValue() - 1; i >= 0; i--)
    {
        array.Add(get(i));
    }
    for (int i = 0; i < array.size(); i++)
    {
        set(new JsNumber(i), array.get(i));
    }
    return (TA)this;
}

public void set(Array array, object offset)
{
    int o = Onekit_JS.number(offset, 0, 0).intValue();
    for (int i = 0, j = o; i < array.size(); i++, j++)
    {
        set(new JsNumber(j), array.get(i));
    }
}
public void set(TypedArray typedArray, object offset)
{
    int o = Onekit_JS.number(offset, 0, 0).intValue();
    for (int i = 0, j = o; i < typedArray.getLength().THIS.intValue(); i++, j++)
    {
        set(new JsNumber(j), typedArray.get(i));
    }
}

public < TA extends TypedArray> TA _slice(int start, int end) {
    start = _index(this, start);
    end = _index(this, end);
    Array array = new Array();
    for (int i = start; i < end; i++)
    {
        array.Add(get(i));
    }
    Class<TA> clazz = (Class<TA>)getClass();
    return TA._of(clazz, array);
}

public < TA extends TypedArray> TA slice(object start, object end) {
    int start_ = Onekit_JS.number(start, 0, 0).intValue();
    int end_ = Onekit_JS.number(end, 0, 0).intValue();
    return _slice(start_, end_);
}

public < TA extends TypedArray> TA slice(object start) {
    return slice(start, new JsNumber(getLength()));
}

public < TA extends TypedArray> TA slice() {
    return slice(new JsNumber(0));
}

public JsBoolean some(function callback, object thisArg)
{
    for (int i = 0; i < getLength().THIS.intValue(); i++)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        if (Onekit_JS.is (callback.invoke(element, new JsNumber(i), this)))
        {
            return new JsBoolean(true);
        }
    }
    return new JsBoolean(false);
}

public < TA extends TypedArray> TA sort(function compareFunction) {
    Array array = new Array();
    for (int i = 0; i < getLength().THIS.intValue(); i++)
    {
        array.Add(get(i));
    }
    Collections.sort(array, new Comparator() {
            override
            public int compare(Object o1, Object o2)
    {
        return ((JsNumber)compareFunction.invoke((object)o1, (object)o2)).THIS.intValue();
    }
});
for (int i = 0; i < array.size(); i++)
{
    set(new JsNumber(i), array.get(i));
}
return (TA)this;
    }

    public  < TA extends TypedArray> TA sort() {
    return sort(new function() {
            override
            public object invoke(params object[]arguments)
    {
        Double v1 = Onekit_JS.number(arguments[0], 0, 0).doubleValue();
        Double v2 = Onekit_JS.number(arguments[1], 0, 0).doubleValue();
        return new JsNumber(v1.compareTo(v2));
    }
});
    }
    public  < TA extends TypedArray> TA subarray(int begin, int end){
    Array array = new Array();
    for (int i = begin; i < end; i++)
    {
        array.Add(get(i));
    }
    Class<TA> clazz = (Class<TA>)getClass();
    return TA._of(clazz, array);
}
public  < TA extends TypedArray> TA subarray(int begin){
    return subarray(begin, getLength().THIS.intValue());
}
public  < TA extends TypedArray> TA subarray(){
    return subarray(0);
}


public string toLocaleString(string locales, Dict options)
{
    StringBuilder result = new StringBuilder();
    for (int i = 0; i < getLength().THIS.intValue(); i++)
    {
        object element = this.get(i);
        if (i > 0)
        {
            result.append(",");
        }
        if (element == null)
        {
            result.append("null");
            continue;
        }
        string str = element.toLocaleString(locales, options);
        result.append(str);
    }
    return new string(result.ToString());
}


public Iterator values()
{
    return new Iterator(this.iterator()) {
            override
            public object getValue(Object value)
    {
        return (object)value;
    }

};
    }

    override
    public object get(object key)
{
    return null;
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
override
    public object get(string key)
{
    return null;
}

override
    public void set(string key, object value)
{

}
}

}
