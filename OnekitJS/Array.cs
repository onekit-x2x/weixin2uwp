using cn.onekit.js.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;

namespace cn.onekit.js
{
    public class Array:List<object>
    {
            public Array(List<object> subList):base(subList)
            {
               
            }

            /////////////////////////////////////////
            public int getLength()
            {
                return this.Count;
            
            }

            private void _setLength(long length)
            {
                if (length < 0 || length >= 4294967296L)
                {
                    throw new RangeError(new String("Invalid array length"));
                }
                if (length > this.Count)
                {
                    return;
                }
                for (long i = length; i <= this.Count; i++)
                {
                    this.Remove(this.Count - 1);
                }
            }

            public void setLength(object length)
            {
                int length_ = Onekit_JS.number(length, 0, 0).intValue();
                _setLength(length_);
            }

            int _hashCode = new Random().Next();

            override
       public int GetHashCode()
            {
                return _hashCode;
            }

            private static int _index(Array array, int index)
            {
                if (index >= 0)
                {
                    return index;
                }
                return array.Count + index;
            }

        override
            public string ToString()
            {

                StringBuilder result = new StringBuilder();
                result.Append("[");
                for (int i = 0; i < Count; i++)
                {
                    object element = this[i];
                    if (i > 0)
                    {
                        result.Append(",");
                    }
                    result.Append(element == null ? "empty" : Onekit_JS.ToString(element));

                }
                result.Append("]");
                return new string(result.ToString());
            }

            //////////////////////////////////////
            public static Array from(object arrayLike, object mapFn, object thisArg)
            {
                function fn = (function)mapFn;
                if (arrayLike is Array) {
                return from((Array)arrayLike, fn, thisArg);
            } else if (arrayLike is string) {
                return from(((string)arrayLike).THIS, fn, thisArg);
            } else
            {
                return null;
            }
        }

        private static Array from(Array array, object mapFn, object thisArg)
        {
            Array result = new Array();
            foreach (object element in array)
            {
                if (mapFn != null)
                {
                    result.Add(mapFn.invoke(element));
                }
                else
                {
                    result.Add(element);
                }
            }
            return result;
        }

        private static Array from(string arrayLike, object mapFn, object thisArg)
        {
            return from(Onekit_JS.string2Array(arrayLike), mapFn, thisArg);
        }


        //
        public static bool isArray(object obj)
        {
            return obj is Array;
        }

        //
        public static Array of(params object[] elements)
        {
            Array result = new Array();
            Collections.addAll(result, elements);
            return result;
        }

        /////////////////////////////////////////
        public Array()
        {
        }

        public Array(object length)
        {
            if (length == null)
            {
                Add(null);
                return;
            }
            if (Onekit_JS.isNumber(length))
            {
                long length_ = ((JsNumber)length).THIS.longValue();
                if (length_ <= 0 || length_ >= 4294967296L)
                {
                    throw new Error(new string("Invalid array length"));
                }
                for (int i = 0; i < length_; i++)
                {
                    this.Add(null);
                }
            }
            else
            {
                Add(length);
            }
        }

        public Array(params object[] args)
        {

            this.AddRange( args);

        }
        /////////////////////////////////////////////////

        public Array concat(params object[] values)
        {
            Array RESULT = new Array();
            RESULT.AddRange(this);
            foreach (object value in values)
            {
                if (value is Array) {
                Array array = (Array)value;
                   RESULT.AddRange(array);
            } else
            {
                RESULT.Add(value);
            }
        }
        return RESULT;
    }

    //
    private Array _copyWithin(int target, int start, int end)
    {
        target = _index(this, target);
        start = _index(this, start);
        end = _index(this, end);
        Array result = new Array();
        result.AddRange(this);
        for (int i = start, j = 0; i < end && i < result.Count && target + j < result.Count; i++, j++)
        {
            result[target + j]= this[i];
        }
        return result;
    }

    public Array copyWithin(int target, int start, int end)
    {
        target = _index(this, target);
        start = _index(this, start);
        end = _index(this, end);
        Array result = new Array();
        result.addAll(this);
        for (int i = start, j = 0; i < end && i < result.Count && target + j < result.Count; i++, j++)
        {
            result.set(target + j, this.get(i));
        }
        return result;
    }

    public Array copyWithin(int target, int start)
    {
        return copyWithin(target, start, this.Count - 1);
    }

    public Array copyWithin(int target)
    {
        return copyWithin(target, 0);
    }
    //

    public Iterator entries()
    {
        return new Iterator(this.iterator()) {


            override
            public object getValue(Object value)
        {
            return new Array() {
                    Add(new JsNumber(index++));
            Add((object)value);
        }
    };
}

int index = 0;

        };
    }

    //
    public bool every(function callback, object thisArg)
{
    callback.thisArg = thisArg;
    for (int i = 0; i < Count; i++)
    {
        object element = get(i);
        if (element == null)
        {
            continue;
        }

        if (!Onekit_JS.is (callback.invoke(element, new JsNumber(i), this)))
        {
            return false;
        }
    }
    return true;
}

public bool every(function callback)
{
    return every(callback, null);
}


//
private Array _fill(object value, int start, int end)
{
    start = _index(this, start);
    end = _index(this, end);
    for (int i = start; i >= 0 && i < end && i < Count; i++)
    {
        set(i, value);
    }
    return this;
}

public Array fill(object value, object start, object end)
{
    int start_ = Onekit_JS.number(start, 0, 0).intValue();
    int end_ = Onekit_JS.number(end, 0, 0).intValue();
    return _fill(value, start_, end_);
}

public Array fill(object value, object start)
{
    return fill(value, start, new JsNumber(this.Count));
}

public Array fill(object value)
{
    return fill(value, new JsNumber(0));
}

//
public Array filter(function callback, object thisArg)
{
    callback.thisArg = thisArg;
    Array result = new Array();
    for (int i = 0; i < Count; i++)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        if (Onekit_JS.is (callback.invoke(element)))
        {
            result.Add(element);
        }
    }
    return result;
}

public Array filter(function callback)
{
    return filter(callback, null);
}

//
public object find(function callback, object thisArg)
{
    callback.thisArg = thisArg;
    for (int i = 0; i < Count; i++)
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

//
public Integer findIndex(function callback, object thisArg)
{
    callback.thisArg = thisArg;
    for (int i = 0; i < Count; i++)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        if (Onekit_JS.is (callback.invoke(element, new JsNumber(i), this)))
        {
            return i;
        }
    }
    return -1;
}

public Integer findIndex(function callback)
{
    return findIndex(callback, null);
}

//
private Array _flat(int depth, int current)
{
    Array result = new Array();
    for (object element : this) {
    if (element is Array && current < depth) {
        Array array = (Array)element;
        result = result.concat(array._flat(depth, current + 1));
    } else
    {
        result.Add(element);
    }
}
return result;
    }

    public Array flat(int depth)
{
    return _flat(depth, 0);
}

public Array flat()
{
    return flat(1);
}

//
public Array flatMap(function callback, object thisArg)
{
    callback.thisArg = thisArg;
    Array result = new Array();
    for (int i = 0; i < Count; i++)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        result.Add(callback.invoke(element, new JsNumber(i), this).get(new JsNumber(0)));
    }
    return result;
}

public Array flatMap(function callback)
{
    return flatMap(callback, null);
}

//
public void forEach(function callback, object thisArg)
{
    callback.thisArg = thisArg;
    for (int i = 0; i < Count; i++)
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
public JsBoolean includes(object valueToFind, object fromIndex)
{
    int index = Onekit_JS.number(fromIndex, 0, 0).intValue();

    for (int i = index; i < Count; i++)
    {
        if (i < 0)
        {
            continue;
        }
        object element = this.get(i);
        if (element.equals(valueToFind))
        {
            return new JsBoolean(true);
        }
    }
    return new JsBoolean(false);
}

//
public JsNumber indexOf(object searchElement, object fromIndex)
{
    int f = Onekit_JS.number(fromIndex, 0, 0).intValue();
    f = _index(this, f);
    for (int i = f; i < Count; i++)
    {
        object temp = get(i);
        if (searchElement.equals(temp))
        {
            return new JsNumber(i);
        }
    }
    return new JsNumber(-1);
}

public JsNumber indexOf(object searchElement)
{
    return indexOf(searchElement, new JsNumber(0));
}

//
private string _join(string separator)
{
    return StringUtils.join(this, separator);
}

public string join(object separator)
{
    return new string(_join(separator.ToString()));
}

public string join()
{
    return join(new string(","));
}

public Iterator keys()
{
    return new Iterator(this.iterator()) {

            override
            public object getValue(Object value)
    {
        return new JsNumber(index++);
    }

    int index = 0;
};
    }

    public int lastIndexOf(object searchElement, int fromIndex)
{
    fromIndex = _index(this, fromIndex);
    for (int i = fromIndex; i >= 0; i--)
    {
        object temp = get(i);
        if (searchElement.equals(temp))
        {
            return i;
        }
    }
    return -1;
}

public int lastIndexOf(object searchElement)
{
    return lastIndexOf(searchElement, Count - 1);
}

//
public Array map(object callback, object thisArg)
{
    ((function)callback).thisArg = thisArg;
    Array result = new Array();
    for (int i = 0; i < Count; i++)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        result.Add(callback.invoke(element));
    }
    return result;
}

public Array map(object callback)
{
    return map(callback, null);
}
//

public object pop()
{
    if (this.Count == 0)
    {
        return null;
    }
    return Remove(this.Count - 1);
}

public JsNumber push(params object[] elements)
{
    if (elements == null)
    {
        Add(null);
    }
    else
    {
        this.addAll(Arrays.asList(elements));
    }
    return new JsNumber(this.Count);
}

public object reduce(function callback, object initialValue)
{
    bool flag = (initialValue == null);
    if (flag)
    {
        initialValue = get(0);
    }
    for (int i = (flag ? 1 : 0); i < Count; i++)
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
    bool flag = initialValue == null;
    if (flag)
    {
        initialValue = get(Count - 1);
    }
    for (int i = Count - (flag ? 2 : 1); i >= 0; i--)
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

public Array reverse()
{
    Array temp = new Array();
    for (int i = Count - 1; i >= 0; i--)
    {
        temp.Add(get(i));
    }
    clear();
    addAll(temp);
    return this;
}

public object shift()
{
    return this.Remove(0);
}

private Array _slice(int start, int end)
{
    return new Array(this.subList(start, end));
}

public Array slice(object start, object end)
{
    int start_ = Onekit_JS.number(start, 0, 0).intValue();
    int end_ = Onekit_JS.number(end, 0, 0).intValue();
    return _slice(start_, end_);
}

public Array slice(object start)
{
    return slice(start, new JsNumber(this.Count - 1));
}

public Array slice()
{
    return slice(new JsNumber(0));
}

public bool some(function callback, object thisArg)
{
    for (int i = 0; i < Count; i++)
    {
        object element = this.get(i);
        if (element == null)
        {
            continue;
        }
        if (Onekit_JS.is (callback.invoke(element, new JsNumber(i), this)))
        {
            return true;
        }
    }
    return false;
}

public bool some(function callback)
{
    return some(callback, null);
}

public Array sort(function compareFunction)
{
    Collections.sort(this, (o1, o2)-> ((JsNumber)compareFunction.invoke(o1, o2)).THIS.intValue());
    return this;
}

public Array sort()
{

    Collections.sort(this, (o1, o2)-> {
        string str1 = o1.ToString();
        string str2 = o2.ToString();
        str1 = str1.length() > 0 ? str1.substring(0, 1) : "";
        str2 = str2.length() > 0 ? str2.substring(0, 1) : "";
        return str1.compareTo(str2);
    });
return this;
    }

    public Array splice(int start, int deleteCount, params object[] items)
{
    Array result = new Array(subList(start, start + deleteCount));
    this.removeRange(start, start + deleteCount);
    for (object element : items) {
    this.Add(start++, element);
}
return result;
    }

    public Array splice(int start)
{
    return splice(start, Count - start);
}

public string toLocaleString(object locales, Dict options)
{
    StringBuilder result = new StringBuilder();
    for (int i = 0; i < Count; i++)
    {
        object element = this.get(i);
        if (i > 0)
        {
            result.Append(",");
        }
        if (element == null)
        {
            result.Append("null");
            continue;
        }
        string str;
        if (element is Dict) {
    str = ((Dict)element).toLocaleString(locales, options).THIS;
} else if (Onekit_JS.isNumber(element))
{
    str = ((JsNumber)element).toLocaleString(locales, options).THIS;
}
else if (element is Date) {
    str = ((Date)element).toLocaleString(locales, options).THIS;
} else
{
    str = element.ToString();
}
result.Append(str);
        }
        return result.ToString();
    }


    //
    public int unshift(params object[] elements)
{
    int i = 0;
    for (object element : elements) {
    this.Add(i++, element);
}
return this.Count;
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
    int index = Onekit_JS.number(key, 0, 0).intValue();
    return super.get(index);
}

override
    public void set(string key, object value)
{
}

override
    public void set(object key, object value)
{
    int index = Onekit_JS.number(key, 0, 0).intValue();
    set(index, value);
}

    }
}
