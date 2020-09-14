using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onekit
{
    public abstract class function
    {
        public abstract JsObject invoke(params JsObject[] arguments);
    }
}
