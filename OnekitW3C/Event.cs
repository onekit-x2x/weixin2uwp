using cn.onekit.js;
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
        private Dict detail;
        //private Dict  mark;
        //  private bool mut;
        private Element target;
        private int timeStamp;
        private string type;
        //
        public Event(
                string type,
                Dict detail,
                //       Dict  mark,
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
        public Dict getDetail()
        {
            return detail;
        }
        /* public Dict getMark(){
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
        /* public Event(string type,Dict detail){
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
