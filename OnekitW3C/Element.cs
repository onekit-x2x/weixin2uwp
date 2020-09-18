using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace cn.onekit.w3c
{
    public class Element:UserControl,Node
    {
      /*  private int mCounter;
        private bool isReleased;
        private bool isMoved;
        private float mLastMotionX, mLastMotionY;
        private float TOUCH_SLOP;
        private long time1;*/
        ////////////////////////



        public string ClassName { get; set; }
        new public string Style { get; set; }
         public string Id { get; set; }
        public Element():base()
        {
            _init();
        }


        protected void _init()

        {

        }
        protected void _init2()
        {

        }
    }
}
