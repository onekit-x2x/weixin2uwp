using android.content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace java
{
    public static class View_
    {
        public static Visibility GONE
        {
            get
            {
                return Visibility.Collapsed;
            }
        }
    }
        public static class _View_
    {
        public static Panel getParent(this FrameworkElement THIS)
        {
            return (Panel)THIS.Parent;
        }
        public static Visibility getVisibility(this FrameworkElement THIS)
        {
            return THIS.Visibility;
        }
        public static Context getContext(this FrameworkElement THIS)
        {
            return null;
        }
    }
}
