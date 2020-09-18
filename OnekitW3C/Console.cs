using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.w3c
{
    public class Console
    {
        public object assert(params object[] objs)
        {
             System.Console.Out.WriteLine("[ASSERT]"+ string.Join(" ", objs));
            return null;
        }
        public object clear()
        {
            System.Console.Clear();
            return null;
        }
 
        public object countReset(object label)
        {
            return null;
        }
        public object debug(params object[] objs)
        {
            System.Console.Out.WriteLine("[DEBUG]" + string.Join(" ", objs));
            return null;
        }
        public object error(params object[] objs)
        {
            System.Console.Out.WriteLine("[ERROR]" + string.Join(" ", objs));
            return null;
        }
        public object group()
        {
            return null;
        }
        public object groupCollapsed()
        {
            return null;
        }
        public object groupEnd()
        {
            return null;
        }
        public object info(params object[] objs)
        {
            System.Console.Out.WriteLine("[INFO]" + string.Join(" ", objs));
            return null;
        }
        public object log(params object[] objs)
        {
            System.Console.Out.WriteLine("[LOG]" + string.Join(" ", objs));
            return null;
        }
        public object table( object[] objs)
        {
            return null;
        }
        public object time(string timerName)
        {
            return null;
        }
        public object trace(object[] objs)
        {
            return null;
        }
        public object warn(params object[] objs)
        {
            System.Console.Out.WriteLine("[WARN]" + string.Join(" ", objs));
            return null;
        }
    }
}
