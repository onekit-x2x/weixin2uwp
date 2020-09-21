using android.app;
using android.content;
using android.content.pm;
using android.util;
using java;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thekit.android
{
    public class Android
    {
        public static Context context;
        public static Application application()
        {
            try
            {
                return ActivityThread.currentApplication();
            }
            catch (Exception e)
            {
                e.printStackTrace();
                return null;
            }
        }
        public static ComponentName launchActivity(Context context)
        {
            PackageManager pm = context.getPackageManager();
            string packageName = context.getPackageName();
            return pm.getLaunchIntentForPackage(packageName).getComponent();
        }
        public static string launchActivityName(Context context)
        {
            return launchActivity(context).getClassName();
        }
        /*
        public static ComponentName currentActivty(Context context) {
            ActivityManager manager = (ActivityManager) context.getSystemService(Context.ACTIVITY_SERVICE);
            ActivityManager.RunningTaskInfo info = manager.getRunningTasks(1).get(0);
           return info.topActivity;
        }
        public static String currentActiivtyName(Context context) {
            return Android.currentActivty(context).getClassName();
        }*/
        public static Size SIZE()
        {
            DisplayMetrics metric = getDisplayMetrics();
            Size size = new Size(metric.widthPixels, metric.heightPixels);
            return size;//new Size(size.getWidth()/2,size.getHeight()/2);
        }
        static DisplayMetrics displayMetrics;
         static DisplayMetrics getDisplayMetrics()
        {
            if (displayMetrics == null)
            {
                displayMetrics = context.getResources().getDisplayMetrics();
            }
            return displayMetrics;
        }

        public static int dp2px(float dp)
        {
            return (int)TypedValue.applyDimension(TypedValue.COMPLEX_UNIT_DIP, dp, getDisplayMetrics());
        }

        public static float px2dp(int px)
        {
            return px / (getDisplayMetrics().density);
        }
    }
}
