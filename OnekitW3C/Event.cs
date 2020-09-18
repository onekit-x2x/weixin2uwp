
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.onekit.w3c
{
    public class Event:EventArgs
    {
        private Element currentTarget;
        private IDictionary<string,object> detail;
        //private IDictionary<string,object>  mark;
        //  private bool mut;
        private Element target;
        private int timeStamp;
        private string type;
        //
        public Event(
                string type,
                IDictionary<string,object> detail,
                //       IDictionary<string,object>  mark,
                //   bool mut,
                Element currentTarget,
                Element target,
             int timeStamp)
        {
            this.currentTarget = currentTarget;
            this.detail = detail;
            // this.mark=mark;
            //   this.mut=mut;
            this.target = target;
            this.timeStamp = timeStamp;
            this.type = type;
        }
        //
        public Element getCurrentTarget()
        {
            return currentTarget;
        }
        public IDictionary<string,object> getDetail()
        {
            return detail;
        }
        /* public IDictionary<string,object> getMark(){
             return mark;
         }*/
        /* public bool getMut(){
             return mut;
         }*/
        public Element getTarget()
        {
            return target;
        }
        public int getTimeStamp()
        {
            return timeStamp;
        }
        public string getType()
        {
            return type;
        }
        /* public Event(string type,IDictionary<string,object> detail){
             this.type=type;
             this.detail = detail;
         }*/

        override
    public string ToString()
        {
            return string.Format("\"currentTarget\":{0},\"detail\":{1},\"mark\":{2},\"mut\":{3},\"target\":{4},\"timeStamp\":{5},\"type\":\"{6}\"}",
                    currentTarget,
                    detail,
                    "mark",
                    "mut",
                    target,
                    timeStamp,
                    type);
        }

    }
}
