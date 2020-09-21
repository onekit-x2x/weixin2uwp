using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace android.util
{
    public class Size
    {
        private object widthPixels;
        private object heightPixels;

        public Size(object widthPixels, object heightPixels)
        {
            this.widthPixels = widthPixels;
            this.heightPixels = heightPixels;
        }
    }
}
