using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace android.os
{
    public class Bundle
    {
        private Dictionary<string, object> dict = new Dictionary<string, object>();
        public Dictionary<string,object>.KeyCollection keySet()
        {
            return dict.Keys;
        }
        public void putString(string key,string value)
        {
           dict[key] = value;
        }
        public string getString(string key)
        {
            return (string)dict[key];
        }
    }
}
