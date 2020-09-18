using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Promise 
    {
        function _callback;

        override
    public string ToString()
    {
        return "[obj Promise]";
    }

    ///////////////////////////////
    public Promise(function callback)
    {
        _callback = callback;
    }

    //////////////////////////////////
    public static Promise all(Array iterable)
    {
        return null;
        /*return new Promise((resolve, reject) -> {
            Array result = new Array();
            for (object item : iterable) {
                if (item instanceof Promise) {
                    Promise promise = (Promise) item;
                    //promise.then(new cn.onekit.js.core.function() {
                   //     override
                   //     public object invoke(params object[] arguments) {
                  //          object arg=arguments[0];
                  //           result.Add(arg);
                 //            return null;
                 //       }
                //    });
                } else {
                    result.Add(item);
                }
            }
      // reject).invoke(result);
            return null;
        });*/
    }

    public static Promise all(string iterable)
    {
        return null;
    }

    public static Promise allSettled(Array iterable)
    {
        return null;
    }

    public static Promise allSettled(string iterable)
    {
        return null;
    }

    public Promise Catch(function onRejected)
    {
        return null;
    }

    public Promise Finally(function onFinally)
    {
        return null;
    }

    public Promise then(cn.onekit.js.core.function onFulfilled, cn.onekit.js.core.function onRejected)
    {
        _callback.invoke(onFulfilled, onRejected);
        return this;
    }

    public Promise then(cn.onekit.js.core.function onFulfilled)
    {
        return then(onFulfilled, null);
    }

    public static Promise race(Array iterable)
    {
        return null;
    }

    public static Promise race(string iterable)
    {
        return null;
    }

    public static Promise reject(Error reason)
    {
        return null;//new Promise((resolve, reject) -> (()invoke(reason));
    }

    public static Promise resolve(object value)
    {
        return new Promise(new function(){

            override
            public object invoke(params object[]arguments)
        {
            try
            {
                function resolve = (function)arguments[0];
                resolve.invoke(value);
            }
            catch (Exception e)
            {
                e.printStackTrace();
                function reject = (function)arguments[1];
                reject.invoke(value);
            }
            return null;
        }
    });
    }

override
    public object get(string key)
{
    return null;
}

override
    public object get(object key)
{
    return null;
}

override
    public void set(string key, object value)
{

}

override
    public void set(object key, object value)
{

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
}

}
