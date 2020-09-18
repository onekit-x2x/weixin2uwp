using java;
using thekit;
using boolean = System.Boolean;
using View = Windows.UI.Xaml.FrameworkElement;
using ViewGroup = Windows.UI.Xaml.Controls.Panel;
using Activity = Windows.UI.Xaml.Controls.Page;
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
                if (v.getVisibility() == View_.GONE)
                {
                    continue;
                }
                if (v is LITERAL_){
                continue;
            }
            if (v is BeforeAfter_){
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

    public static boolean isRoot(View view)
    {

        return view.getParent().hashCode() == ((Activity)view.getContext()).findViewById(android.R.id.content).hashCode();
    }

    /*  public static <JsObject : View> JsObject getRoot(Context context) {
          return  ((Activity)context).getWindow().getDecorView();
      }*/
}

}
