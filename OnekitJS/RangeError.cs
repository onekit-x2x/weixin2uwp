using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class RangeError : Error
    {
        public RangeError(object message) : base(message)
        {
        }
    }
}
