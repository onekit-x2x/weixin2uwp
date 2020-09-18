using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;

namespace cn.onekit.w3c.core
{
    public interface FormItem_<T> where T : IJsonValue
    {
        void setName(string name);

        string getName();

        //
        void setValue(T value);

        T getValue();

        ///////////////////////////
        void reset();
    }
}