using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class ReferenceError : Error
    {
        public ReferenceError(object message) : base(message)
        {
        }
    }
}
