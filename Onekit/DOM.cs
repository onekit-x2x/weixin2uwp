using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onekit
{
    public class DOM
    {
        public static int index0(View THIS)
        {
            for (int i = 0; i < ((ViewGroup)THIS.getParent()).getChildCount(); i++)
            {
                View v = ((ViewGroup)THIS.getParent()).getChildAt(i);
                if (v.hashCode() == THIS.hashCode())
                {
                    return i;
                }
            }
            return -1;
        }

        public static int index(View THIS)
        {
            int result = 0;
            for (int i = 0; i < ((ViewGroup)THIS.getParent()).getChildCount(); i++)
            {
                View v = ((ViewGroup)THIS.getParent()).getChildAt(i);
                if (v.getVisibility() == View.GONE)
                {
                    continue;
                }
                if (v instanceof LITERAL_){
                continue;
            }
            if (v instanceof BeforeAfter_){
                continue;
            }
            if (v.hashCode() == THIS.hashCode())
            {
                return result;
            }
            result++;
        }
        return -1;
    }

    public static bool isRoot(View view)
    {

        return view.getParent().hashCode() == ((Activity)view.getContext()).findViewById(android.R.id.content).hashCode();
    }

    /*  public static <JsObject extends View> JsObject getRoot(Context context) {
          return  ((Activity)context).getWindow().getDecorView();
      }*/
}
}
