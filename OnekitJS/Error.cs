using cn.onekit.js.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class Error : Exception , object {

        public Error(object message)   :base(string.Format("{0}",message))
        {
         
        }
    }

}
