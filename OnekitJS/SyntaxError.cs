using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.js
{
    public class SyntaxError : Error
    {
        public SyntaxError(object message) : base(message)
        {
        }
    }
}
