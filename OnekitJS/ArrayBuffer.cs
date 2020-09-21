﻿using cn.onekit.js.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class ArrayBuffer: JsObject
    {
        public byte[] _data;
        public ArrayBuffer(byte[] data)
        {
            _data = data;
        } 
        public ArrayBuffer(JsObject data)
        {
            if (data is JsArray) {
                JsArray array = (JsArray)data;
                this._data = new byte[array.size()];
                for (int i = 0; i < array.size(); i++)
                {
                    JsNumber item = (JsNumber)array.get(i);
                    this._data[i] = item.THIS.byteValue();
                }
            } else if (data is JsNumber) {
                _data = new byte[((JsNumber)data).THIS.intValue()];
            }
        }

        public JsString ToString()
        {
            return new JsString(String.format("ArrayBuffer { byteLength: %d }", getByteLength()));
        }

        @Override
    public String toLocaleString(JsString locales, JsObject options)
        {
            return null;
        }

        @Override
    public JsObject invoke(JsObject... params)
        {
            return null;
        }

        ////////////////////////////////////
        public JsObject getByteLength()
        {
            return new JsNumber(_data.length);
        }

        public JsNumber get(int index)
        {
            return new JsNumber(_data[index]);
        }

        public static JsBoolean isView(JsObject arg)
        {
            if (arg == null)
            {
                return new JsBoolean(false);
            }
            return new JsBoolean((arg is TypedArray) || (arg is DataView));
        }

        public static boolean isView()
        {
            return false;
        }

        public ArrayBuffer slice(JsObject begin, JsObject end)
        {
            int b = Onekit_JS.number(begin, 0, 0).intValue();
            int e = Onekit_JS.number(end, 0, 0).intValue();
            byte[] data = new byte[e - b];
            System.arraycopy(this._data, b, data, 0, e - b);
            ArrayBuffer result = new ArrayBuffer(new JsNumber(e - b));
            result._data = data;
            return result;
        }

        public ArrayBuffer slice(JsNumber begin)
        {
            return slice(begin, getByteLength());
        }

        public static ArrayBuffer transfer(ArrayBuffer oldBuffer, JsObject newByteLength)
        {
            ArrayBuffer result = new ArrayBuffer(newByteLength);
            int len = ((JsNumber)newByteLength).THIS.intValue();
            for (int i = 0; i < len && i < oldBuffer._data.length; i++)
            {
                result._data[i] = oldBuffer._data[i];
            }

            oldBuffer._data = new byte[] { };
            return result;
        }

        public static ArrayBuffer transfer(ArrayBuffer oldBuffer)
        {
            return transfer(oldBuffer, oldBuffer.getByteLength());
        }

        @Override
    public JsObject get(String key)
        {
            return null;
        }

        @Override
    public JsObject get(JsObject key)
        {
            return null;
        }

        @Override
    public void set(String key, JsObject value)
        {

        }

        @Override
    public void set(JsObject key, JsObject value)
        {

        }
    }
}
