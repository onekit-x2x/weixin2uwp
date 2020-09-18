using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class TypeError : Error
    {
        public TypeError(object message) : base(message)
        {
        }
    }
}
